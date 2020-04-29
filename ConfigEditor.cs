using DolphinConfigEditor.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DolphinConfigEditor
{
  public partial class ConfigEditor : Form
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new ConfigEditor());
    }

    public ConfigEditor()
    {
      InitializeComponent();

      playerListGrid.Columns[CID].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
      playerListGrid.Columns[DEADZONE].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
      playerListGrid.Columns[LOCKORDER].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
      for (int i = 0; i < 8; i++)
      {
        playerListGrid.Rows.Add();
        playerListGrid.Rows[i].Cells[CID].Value = $"{i}";
        playerListGrid.Rows[i].Cells[CID].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        playerListGrid.Rows[i].Cells[LAYOUT].Value = "Xbox";
        playerListGrid.Rows[i].Cells[DEADZONE].Value = "10";
        playerListGrid.Rows[i].Cells[DEADZONE].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        playerListGrid.Rows[i].Cells[PORT].Value = $"Player {(i / 2) + 1}";
        playerListGrid.Rows[i].Cells[LOCKORDER].Value = "false";
      }
    }

    private void btnRandomize_Click(object sender, EventArgs e)
    {
      playerListGrid.ClearSelection();

      var sortList = new System.Collections.Generic.List<string>();
      for (int i = 0; i < playerListGrid.Rows.Count; i++)
        if (playerListGrid.Rows[i].Cells[LOCKORDER].Value.ToString().Equals("false"))
          sortList.Add(playerListGrid.Rows[i].Cells[PORT].Value.ToString());
      sortList = sortList.OrderBy(r => rnd.Next()).ToList();

      int sortListIdx = 0;
      for (int i = 0; i < playerListGrid.Rows.Count; i++)
        if (playerListGrid.Rows[i].Cells[LOCKORDER].Value.ToString().Equals("false"))
          playerListGrid.Rows[i].Cells[PORT].Value = sortList[sortListIdx++];

      playerListGrid.Sort(playerListGrid.Columns[PORT], ListSortDirection.Ascending);
      System.Media.SystemSounds.Beep.Play();
    }

    private void btnSaveCfg_Click(object sender, EventArgs e)
    {
      playerListGrid.ClearSelection();
      playerListGrid.Sort(playerListGrid.Columns[PORT], ListSortDirection.Ascending);
      string fileOutput = "";

      for (int i = 0; i < 8; i += 2)
      {
        Controller c = new Controller();
        DataGridViewRow row = playerListGrid.Rows[i];

        c.port = (i / 2) + 1;

        c.cid1 = Convert.ToInt32(row.Cells[CID].Value.ToString());
        c.la1 = row.Cells[LAYOUT].Value.ToString();
        c.dz1 = Convert.ToInt32(row.Cells[DEADZONE].Value.ToString());

        row = playerListGrid.Rows[i + 1];
        c.cid2 = Convert.ToInt32(row.Cells[CID].Value.ToString());
        c.la2 = row.Cells[LAYOUT].Value.ToString();
        c.dz2 = Convert.ToInt32(row.Cells[DEADZONE].Value.ToString());
        fileOutput += c;
      }

      try
      {
        File.Delete(openConfigDialog.FileName);
        var sw = new StreamWriter(txtConfigFile.Text);
        sw.Write(fileOutput);
        sw.Flush();
        sw.Close();
        System.Media.SystemSounds.Beep.Play();
      }
      catch (Exception)
      {
        Clipboard.SetText(fileOutput);
        MessageBox.Show("There was an error writing to the config file :(\n\n" +
          "Output has been copied to clipboard. Please manually overrite the config.",
          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Console.WriteLine(fileOutput);
      }
    }

    private void gameCtrlsBtn_Click(object sender, EventArgs e)
    {
      try
      {
        var path = System.Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\joy.cpl";
        var fi = new System.IO.FileInfo(path);
        var psi = new System.Diagnostics.ProcessStartInfo(path);
        psi.UseShellExecute = true;
        psi.WorkingDirectory = fi.Directory.FullName;
        psi.ErrorDialog = true;
        System.Diagnostics.Process.Start(psi);
      }
      catch (Exception) { }
    }

    private void btnCfgOpen_Click(object sender, EventArgs e)
    {
      playerListGrid.ClearSelection();
      if (openConfigDialog.ShowDialog() == DialogResult.OK)
        txtConfigFile.Text = openConfigDialog.FileName;
    }

    private void playerListGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1);
      DataGridView datagridview = sender as DataGridView;

      if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
        datagridview.BeginEdit(true);
    }

    private void playerListGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
      playerListGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
    }

    private void playerListGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
    {
      e.SortResult = string.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
      /* Secondary sort for CID disabled
      if (e.SortResult == 0 && e.Column.Index != CID)
        e.SortResult = string.Compare(
          playerListGrid.Rows[e.RowIndex1].Cells[CID].Value.ToString(),
          playerListGrid.Rows[e.RowIndex2].Cells[CID].Value.ToString()
        );
      */
      e.Handled = true;
    }

    private static int CID = 1;
    private static int LAYOUT = 2;
    private static int DEADZONE = 3;
    private static int PORT = 4;
    private static int LOCKORDER = 5;

    private Random rnd = new Random();
  }
}
