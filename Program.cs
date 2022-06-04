using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace RS485tool
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]

    
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string errmsg = "";
      bool ok = false;
      bool forceNetworkAPI =false;
      string addr = "127.0.0.1";
      if (args.Length > 0) { addr = args[0]; forceNetworkAPI = true; }
      if (YAPI.TestHub(addr, 200, ref errmsg) == YAPI.SUCCESS)
      { ok = (YAPI.RegisterHub(addr, ref errmsg) == YAPI.SUCCESS);
        UsingInterface = (addr== "127.0.0.1"?  "local VirtualHub" : addr+" hub");
      } else
      if (!forceNetworkAPI)
      {
        ok = (YAPI.RegisterHub("usb", ref errmsg) == YAPI.SUCCESS);
        UsingInterface = "local USB";
      }
        if (ok)  Application.Run(new MainForm());
      else MessageBox.Show("Failed to start Yoctopuce API on "+ addr + " (" + errmsg + ")", "RS485 tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
      YAPI.FreeAPI();
    }
    static public String UsingInterface = "";
  }
}
