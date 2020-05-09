using System;

namespace DolphinConfigEditor.Model {
  public class Controller {
    public enum Cols {
      Port = 0,
      P2 = 2,
      P3 = 3,
      P4 = 4,
    }

    public int port { get; set; }
    public int cid1 { get; set; }
    public int cid2 { get; set; }
    public string la1 { get; set; }
    public string la2 { get; set; }
    public int dz1 { get; set; }
    public int dz2 { get; set; }

    public override string ToString() {
      ControllerMap p1 = ControllerMap.GetMap(cid1, la1);
      ControllerMap p2 = ControllerMap.GetMap(cid2, la2);

      string cfg = $"[GCPad{port}]\n";
      cfg += "Device = DInput/0/Keyboard Mouse\n";

      cfg += $"Buttons/A = {p1.ButtonA}|{p2.ButtonA}\n";
      cfg += $"Buttons/B = {p1.ButtonB}|{p2.ButtonB}\n";
      cfg += $"Buttons/X = {p1.ButtonX}|{p2.ButtonX}\n";
      cfg += $"Buttons/Y = {p1.ButtonY}|{p2.ButtonY}\n";

      cfg += $"Buttons/Z = {p1.ButtonZ}|{p2.ButtonZ}\n";
      cfg += $"Buttons/Start = {p1.ButtonStart}|{p2.ButtonStart}\n";

      cfg += $"Main Stick/Up = {p1.MainStickUp}|{p2.MainStickUp}\n";
      cfg += $"Main Stick/Down = {p1.MainStickDown}|{p2.MainStickDown}\n";
      cfg += $"Main Stick/Left = {p1.MainStickLeft}|{p2.MainStickLeft}\n";
      cfg += $"Main Stick/Right = {p1.MainStickRight}|{p2.MainStickRight}\n";

      cfg += $"C-Stick/Up = {p1.CStickUp}|{p2.CStickUp}\n";
      cfg += $"C-Stick/Down = {p1.CStickDown}|{p2.CStickDown}\n";
      cfg += $"C-Stick/Left = {p1.CStickLeft}|{p2.CStickLeft}\n";
      cfg += $"C-Stick/Right = {p1.CStickRight}|{p2.CStickRight}\n";

      cfg += $"Triggers/L = {p1.TriggerL}|{p2.TriggerL}\n";
      cfg += $"Triggers/R = {p1.TriggerR}|{p2.TriggerR}\n";
      cfg += $"Triggers/L-Analog = {p1.TriggerL}|{p2.TriggerL}\n";
      cfg += $"Triggers/R-Analog = {p1.TriggerR}|{p2.TriggerR}\n";

      cfg += $"D-Pad/Up = {p1.DPadUp}|{p2.DPadUp}\n";
      cfg += $"D-Pad/Down = {p1.DPadDown}|{p2.DPadDown}\n";
      cfg += $"D-Pad/Left = {p1.DPadLeft}|{p2.DPadLeft}\n";
      cfg += $"D-Pad/Right = {p1.DPadRight}|{p2.DPadRight}\n";

      cfg += $"Rumble/Motor = {p1.Rumble}|{p2.Rumble}\n";
      cfg += $"Main Stick/Dead Zone = {Math.Max(dz1, dz2)}.0\n";
      cfg += $"C-Stick/Dead Zone = {Math.Max(dz1, dz2)}.0\n";

      return cfg;
    }
  }
}
