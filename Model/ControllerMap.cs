namespace DolphinConfigEditor.Model
{
  class ControllerMap
  {
    public string ButtonA { get; set; }
    public string ButtonB { get; set; }
    public string ButtonX { get; set; }
    public string ButtonY { get; set; }

    public string ButtonZ { get; set; }
    public string ButtonStart { get; set; }

    public string MainStickUp { get; set; }
    public string MainStickDown { get; set; }
    public string MainStickLeft { get; set; }
    public string MainStickRight { get; set; }

    public string CStickUp { get; set; }
    public string CStickDown { get; set; }
    public string CStickLeft { get; set; }
    public string CStickRight { get; set; }

    public string TriggerL { get; set; }
    public string TriggerR { get; set; }

    public string DPadUp { get; set; }
    public string DPadDown { get; set; }
    public string DPadLeft { get; set; }
    public string DPadRight { get; set; }

    public static ControllerMap GetMap(int cid, string layout)
    {
      if (layout == "Keyboard")
        return GetMapKB();
      return GetMapController(cid, layout);
    }

    private static ControllerMap GetMapController(int cid, string layout)
    {
      ControllerMap c = new ControllerMap();

      c.ButtonA = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Button {(layout == "Xbox" ? 'A' : 'B')}`";
      c.ButtonB = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Button {(layout == "Xbox" ? 'B' : 'A')}`";
      c.ButtonX = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Button {(layout == "Xbox" ? 'X' : 'Y')}`";
      c.ButtonY = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Button {(layout == "Xbox" ? 'Y' : 'X')}`";

      c.ButtonZ = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Bumper R`";
      c.ButtonStart = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Start`";

      c.MainStickUp = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Left Y+`";
      c.MainStickDown = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Left Y-`";
      c.MainStickLeft = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Left X-`";
      c.MainStickRight = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Left X+`";

      c.CStickUp = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Right Y+`";
      c.CStickDown = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Right Y-`";
      c.CStickLeft = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Right X-`";
      c.CStickRight = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Right X+`";

      c.TriggerL = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Trigger L`";
      c.TriggerR = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Trigger R`";

      c.DPadUp = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Pad N`";
      c.DPadDown = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Pad S`";
      c.DPadLeft = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Pad W`";
      c.DPadRight = $"`WGInput/{cid}/Xbox 360 Controller for Windows:Pad E`";

      return c;
    }

    private static ControllerMap GetMapKB()
    {
      ControllerMap c = new ControllerMap();

      c.ButtonA = "J";
      c.ButtonB = "K";
      c.ButtonX = "L";
      c.ButtonY = "I";

      c.ButtonZ = "R";
      c.ButtonStart = "SEMICOLON";

      c.MainStickUp = "W";
      c.MainStickDown = "S";
      c.MainStickLeft = "A";
      c.MainStickRight = "D";

      c.CStickUp = "UP";
      c.CStickDown = "DOWN";
      c.CStickLeft = "LEFT";
      c.CStickRight = "RIGHT";

      c.TriggerL = "Q";
      c.TriggerR = "E";

      c.DPadUp = "``";
      c.DPadDown = "``";
      c.DPadLeft = "``";
      c.DPadRight = "``";

      return c;
    }
  }
}
