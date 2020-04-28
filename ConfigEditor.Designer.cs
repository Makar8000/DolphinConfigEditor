namespace DolphinConfigEditor
{
  partial class ConfigEditor
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditor));
      this.playerListGrid = new System.Windows.Forms.DataGridView();
      this.colPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLayout = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colDeadZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPort = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.btnSaveCfg = new System.Windows.Forms.Button();
      this.btnRandomize = new System.Windows.Forms.Button();
      this.openConfigDialog = new System.Windows.Forms.OpenFileDialog();
      this.btnCfgOpen = new System.Windows.Forms.Button();
      this.lblCfgLoc = new System.Windows.Forms.Label();
      this.txtConfigFile = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.playerListGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // playerListGrid
      // 
      this.playerListGrid.AllowUserToAddRows = false;
      this.playerListGrid.AllowUserToDeleteRows = false;
      this.playerListGrid.AllowUserToResizeColumns = false;
      this.playerListGrid.AllowUserToResizeRows = false;
      this.playerListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.playerListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.playerListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlayerName,
            this.colCID,
            this.colLayout,
            this.colDeadZone,
            this.colPort});
      this.playerListGrid.Location = new System.Drawing.Point(12, 12);
      this.playerListGrid.Name = "playerListGrid";
      this.playerListGrid.RowHeadersVisible = false;
      this.playerListGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.playerListGrid.Size = new System.Drawing.Size(422, 199);
      this.playerListGrid.TabIndex = 0;
      this.playerListGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerListGrid_CellEnter);
      this.playerListGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.playerListGrid_CurrentCellDirtyStateChanged);
      this.playerListGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.playerListGrid_SortCompare);
      // 
      // colPlayerName
      // 
      this.colPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colPlayerName.HeaderText = "Player Name";
      this.colPlayerName.MaxInputLength = 20;
      this.colPlayerName.Name = "colPlayerName";
      this.colPlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // colCID
      // 
      this.colCID.HeaderText = "CID";
      this.colCID.MaxInputLength = 1;
      this.colCID.MinimumWidth = 40;
      this.colCID.Name = "colCID";
      this.colCID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colCID.ToolTipText = "Controller ID";
      this.colCID.Width = 40;
      // 
      // colLayout
      // 
      this.colLayout.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
      this.colLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.colLayout.HeaderText = "Layout";
      this.colLayout.Items.AddRange(new object[] {
            "Xbox",
            "Switch",
            "Keyboard"});
      this.colLayout.MinimumWidth = 80;
      this.colLayout.Name = "colLayout";
      this.colLayout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colLayout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.colLayout.ToolTipText = "Button Layout";
      this.colLayout.Width = 80;
      // 
      // colDeadZone
      // 
      this.colDeadZone.HeaderText = "DZ";
      this.colDeadZone.MaxInputLength = 2;
      this.colDeadZone.MinimumWidth = 40;
      this.colDeadZone.Name = "colDeadZone";
      this.colDeadZone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colDeadZone.ToolTipText = "Dead Zone";
      this.colDeadZone.Width = 40;
      // 
      // colPort
      // 
      this.colPort.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
      this.colPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.colPort.HeaderText = "Controller";
      this.colPort.Items.AddRange(new object[] {
            "Player 1",
            "Player 2",
            "Player 3",
            "Player 4"});
      this.colPort.MinimumWidth = 100;
      this.colPort.Name = "colPort";
      this.colPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.colPort.ToolTipText = "Controller Port";
      // 
      // btnSaveCfg
      // 
      this.btnSaveCfg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSaveCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSaveCfg.Location = new System.Drawing.Point(12, 300);
      this.btnSaveCfg.Name = "btnSaveCfg";
      this.btnSaveCfg.Size = new System.Drawing.Size(422, 40);
      this.btnSaveCfg.TabIndex = 1;
      this.btnSaveCfg.Text = "Save Config";
      this.btnSaveCfg.UseVisualStyleBackColor = true;
      this.btnSaveCfg.Click += new System.EventHandler(this.btnSaveCfg_Click);
      // 
      // btnRandomize
      // 
      this.btnRandomize.Location = new System.Drawing.Point(11, 217);
      this.btnRandomize.Name = "btnRandomize";
      this.btnRandomize.Size = new System.Drawing.Size(121, 23);
      this.btnRandomize.TabIndex = 4;
      this.btnRandomize.Text = "Randomize Groups";
      this.btnRandomize.UseVisualStyleBackColor = true;
      this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
      // 
      // openConfigDialog
      // 
      this.openConfigDialog.AddExtension = false;
      this.openConfigDialog.FileName = "GCPadNew.ini";
      this.openConfigDialog.Filter = "GCPadNew|GCPadNew.ini";
      this.openConfigDialog.InitialDirectory = "D:\\Users\\Mark\\Source\\Repos\\dolphin\\Binary\\x64\\User\\Config\\";
      this.openConfigDialog.Title = "Select GCPadNew.ini";
      // 
      // btnCfgOpen
      // 
      this.btnCfgOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCfgOpen.Location = new System.Drawing.Point(403, 272);
      this.btnCfgOpen.Name = "btnCfgOpen";
      this.btnCfgOpen.Size = new System.Drawing.Size(31, 23);
      this.btnCfgOpen.TabIndex = 5;
      this.btnCfgOpen.Text = "...";
      this.btnCfgOpen.UseVisualStyleBackColor = true;
      this.btnCfgOpen.Click += new System.EventHandler(this.btnCfgOpen_Click);
      // 
      // lblCfgLoc
      // 
      this.lblCfgLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCfgLoc.AutoSize = true;
      this.lblCfgLoc.Location = new System.Drawing.Point(13, 258);
      this.lblCfgLoc.Name = "lblCfgLoc";
      this.lblCfgLoc.Size = new System.Drawing.Size(56, 13);
      this.lblCfgLoc.TabIndex = 6;
      this.lblCfgLoc.Text = "Config File";
      // 
      // txtConfigFile
      // 
      this.txtConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConfigFile.Location = new System.Drawing.Point(12, 274);
      this.txtConfigFile.Name = "txtConfigFile";
      this.txtConfigFile.ReadOnly = true;
      this.txtConfigFile.Size = new System.Drawing.Size(385, 20);
      this.txtConfigFile.TabIndex = 7;
      this.txtConfigFile.Text = "D:\\Users\\Mark\\Source\\Repos\\dolphin\\Binary\\x64\\User\\Config\\GCPadNew.ini";
      // 
      // ConfigEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(446, 352);
      this.Controls.Add(this.txtConfigFile);
      this.Controls.Add(this.lblCfgLoc);
      this.Controls.Add(this.btnCfgOpen);
      this.Controls.Add(this.btnRandomize);
      this.Controls.Add(this.btnSaveCfg);
      this.Controls.Add(this.playerListGrid);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ConfigEditor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dolphin Config Editor";
      ((System.ComponentModel.ISupportInitialize)(this.playerListGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView playerListGrid;
    private System.Windows.Forms.Button btnSaveCfg;
    private System.Windows.Forms.Button btnRandomize;
    private System.Windows.Forms.OpenFileDialog openConfigDialog;
    private System.Windows.Forms.Button btnCfgOpen;
    private System.Windows.Forms.Label lblCfgLoc;
    private System.Windows.Forms.TextBox txtConfigFile;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPlayerName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCID;
    private System.Windows.Forms.DataGridViewComboBoxColumn colLayout;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDeadZone;
    private System.Windows.Forms.DataGridViewComboBoxColumn colPort;
  }
}

