using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RS485tool
{



  public partial class MainForm : Form
  {

    class PortItem
    {
      YSerialPort p;
      public PortItem(YSerialPort p)
      {
        this.p = p;

      }

      public YSerialPort port
      { get { return this.p; } }

      public override string ToString()
      {
        return p.get_friendlyName();

      }
    }

    bool UpdateNeeded = false;
    bool disableUpdatecallback = false;
    static string buildNumber="PATCH_WITH_BUILD";

    public void deviceArrival(YModule m) { log("Device arrival: " + m.get_hardwareId()); UpdateNeeded = true; m.registerConfigChangeCallback(deviceConfigChange); }
    public void deviceRemoval(YModule m) { log("Device removal: " + m.get_hardwareId()); UpdateNeeded = true; }

    public void log(string msg) { textlogs.Text += DateTime.Now.ToString("HH:mm:ss.fff")+ " "+ msg + "\r\n"; }
    // main form initalization
    public MainForm()
    {
     
      InitializeComponent();
      string exe = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
      log("Hello !");
      log("Usage: " + exe + " YoctoHubIpAddress");
      log("Currently using " + Program.UsingInterface);
      log("YAPI version is " + YAPI.GetAPIVersion());
      YAPI.RegisterLogFunction(log);
      YAPI.RegisterDeviceArrivalCallback(deviceArrival);
      YAPI.RegisterDeviceRemovalCallback(deviceRemoval);
      slaveAddr_TextChanged(null, null);
      timer1.Enabled = true;
      if (buildNumber.Substring(0,5)!="PATCH") BuildNumber_label.Text = buildNumber;


      SnoopingContents.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
     
      SnoopingContents.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      SnoopingContents.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    // automatically called when a Yoctôpuce device configuration has changed
    void deviceConfigChange(YModule m)
    {
      if (interfaceChooser.SelectedIndex < 0) return;
      if (((PortItem)interfaceChooser.SelectedItem).port.get_module() == m)
      { // a change occured to the selected module, force an update 
        UpdateNeeded = true;

      }

    }

    // Scan for modbus slaves on the bus.
    private List<int> StartNewModbusScan()
    {
      List<int> addresses = new List<int>();
      string errmsg = "";
      List<int> empty = new List<int>();
      YSerialPort s = ((PortItem)interfaceChooser.SelectedItem).port;
      s.reset();

      for (int i = 1; i <= 247; i++)
      { string cmd = String.Format("{0:X02}", i)+"0300000001";  // try to read holding registers (0x03) #0000 on slave i;
        s.writeMODBUS(cmd);
        progressBar1.Value = (100 * i) / 257;
        try { YAPI.Sleep(150, ref errmsg); } catch (Exception) { return null; }
        
      }
    
      YAPI.Sleep(1000, ref errmsg);
      progressBar1.Value = 0;
      while (s.read_avail() > 0)
      {
        string str = s.readLine();
        try { YAPI.Sleep(100, ref errmsg); } catch (Exception) { return null; }
        log("read " + str);
        if ((str.Length >= 3) && str.StartsWith(":"))
          addresses.Add(Convert.ToInt32(str.Substring(1, 2), 16));
      }
      return addresses;
    }

    // find out in a serialport is alread present in the dropdown chooser
    private PortItem findItemInCombo(YSerialPort p)
    {
      for (int j = 0; j < interfaceChooser.Items.Count; j++)
        if (((PortItem)interfaceChooser.Items[j]).port == p)
          return (PortItem)interfaceChooser.Items[j];
      return null;
    }

    // search for Yocotpuce serial port with Modubus settings
    // and update the UI
    void ScanForRS485interfaces()
    {
      disableUpdatecallback = true;
      List<PortItem> l = new List<PortItem>();
      YSerialPort p = YSerialPort.FirstSerialPort();
      int currentindex = interfaceChooser.SelectedIndex;
      while (p != null)
      {
        string protocol = p.get_protocol().ToUpper();
        if (protocol.IndexOf("MODBUS") >= 0) l.Add(new PortItem(p));  // Filter RS485 interface only
        p = p.nextSerialPort();
      }
      // remove gone interfaces
      for (int i = interfaceChooser.Items.Count - 1; i >= 0; i--)
      {
        if (!l.Contains((PortItem)(interfaceChooser.Items[i]))) interfaceChooser.Items.RemoveAt(i);

      }
      // add new interfaces
      for (int i = 0; i < l.Count; i++)
      {
        if (findItemInCombo(l[i].port) == null) interfaceChooser.Items.Add(l[i]);
      }

      disableUpdatecallback = false;
      if ((interfaceChooser.SelectedIndex < 0) && (interfaceChooser.Items.Count > 0))
        interfaceChooser.SelectedIndex = 0;

      if (interfaceChooser.SelectedIndex < 0) disableConfigDropDrowns();

    }
    // Disable all Dropdown
    private void disableConfigDropDrowns()
    {
      Protocol.Enabled = false;
      Speed.Enabled = false;
      Parity.Enabled = false;
      Protocol.SelectedIndex = -1;
      Speed.SelectedIndex = -1;
      Parity.SelectedIndex = -1;
    }

    // automatic refresh
    int n = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      String errmsg = "";
      YAPI.HandleEvents(ref errmsg);
      if ((n++) % 20 == 0) YAPI.UpdateDeviceList(ref errmsg);
      if (UpdateNeeded) { ScanForRS485interfaces(); UpdateNeeded = false; }
      timer1.Enabled = true;

    }

    // update configuration drop down when current choosen interface has changed
    private void interfaceChooser_SelectedIndexChanged(object sender, EventArgs e)
    {
      ClearSnoopingLogs();
      StopScan = true;
      if (interfaceChooser.SelectedIndex < 0)
      {
        disableConfigDropDrowns();
        return;
      }
      Protocol.Enabled = true;
      Speed.Enabled = true;
      Parity.Enabled = true;
      YSerialPort p = ((PortItem)interfaceChooser.SelectedItem).port;
      if (!p.isOnline()) return;

      String sProtocol = p.get_protocol();
      Boolean found = false;
      for (int i = 0; i < Protocol.Items.Count && !found; i++)
        if (Protocol.Items[i].ToString() == sProtocol) { Protocol.SelectedIndex = i; found = true; }
      if (!found) Protocol.SelectedIndex = Protocol.Items.Add(sProtocol);

      string mode = p.get_serialMode();
      int n = mode.IndexOf(',');
      if (n > 0)
      {
        string sSpeed = mode.Substring(0, n);
        string sParity = mode.Substring(n + 1);
        found = false;
        for (int i = 0; i < Speed.Items.Count && !found; i++)
          if (Speed.Items[i].ToString() == sSpeed) { Speed.SelectedIndex = i; found = true; }
        if (!found) Speed.SelectedIndex = Speed.Items.Add(sSpeed);
        found = false;
        for (int i = 0; i < Parity.Items.Count && !found; i++)
          if (Parity.Items[i].ToString() == sParity) { Parity.SelectedIndex = i; found = true; }
        if (!found) Parity.SelectedIndex = Parity.Items.Add(sParity);
      }

      for (int i=0;i< interfaceChooser.Items.Count;i++ )
      {  if (i == interfaceChooser.SelectedIndex)
          ((PortItem)(interfaceChooser.Items[i])).port.registerSnoopingCallback(SnoopingCallback);
        else
          ((PortItem)(interfaceChooser.Items[i])).port.registerSnoopingCallback(null);
      }
      disableUpdatecallback = false;
    }
    // 
    // empty the Snopping logs contents
    int snoppingTimeMs = 0;
    void ClearSnoopingLogs()
    {
      snoppingTimeMs = 0;
      SnoopingContents.Rows.Clear();

    }

    void SnoopingCallback(YSerialPort source, YSnoopingRecord data)
    {
      int time = data.get_time();
      int direction = data.get_direction();
      string msg = data.get_message();
      snoppingTimeMs += time;

      while (SnoopingContents.Rows.Count > 500)
        SnoopingContents.Rows.RemoveAt(0);

      int index = SnoopingContents.Rows.Add();
      SnoopingContents.Rows[index].Cells[0].Value = (snoppingTimeMs / 1000.0).ToString("0.000") + " s";
      SnoopingContents.Rows[index].Cells[1].Value = direction > 0 ? char.ConvertFromUtf32(0x2190) : char.ConvertFromUtf32(0x2192);
      SnoopingContents.Rows[index].Cells[2].Value = msg + " (" + ((msg.Length - 1) / 2).ToString() + " bytes)"; ;
      String addr = "?";
      
      if (msg.Length > 1)
      { if (msg.Substring(0,1) == ":")
        {
          if (msg.Length >= 3)
            try
            {
              addr = int.Parse(msg.Substring(1, 2), System.Globalization.NumberStyles.HexNumber).ToString() + " (0x" + msg.Substring(1,2) + ")";
              
            }
            catch (Exception) { }
        }
      }
      SnoopingContents.Rows[index].Cells[3].Value = addr;
    
      SnoopingContents.Rows[index].Cells[4].Value = decodeModbusMsgRTU(direction, Protocol.SelectedIndex ==0,msg);
      Application.DoEvents();

    }

    static readonly UInt16[] modbusCRCTable = {
    0X0000, 0XC0C1, 0XC181, 0X0140, 0XC301, 0X03C0, 0X0280, 0XC241,
    0XC601, 0X06C0, 0X0780, 0XC741, 0X0500, 0XC5C1, 0XC481, 0X0440,
    0XCC01, 0X0CC0, 0X0D80, 0XCD41, 0X0F00, 0XCFC1, 0XCE81, 0X0E40,
    0X0A00, 0XCAC1, 0XCB81, 0X0B40, 0XC901, 0X09C0, 0X0880, 0XC841,
    0XD801, 0X18C0, 0X1980, 0XD941, 0X1B00, 0XDBC1, 0XDA81, 0X1A40,
    0X1E00, 0XDEC1, 0XDF81, 0X1F40, 0XDD01, 0X1DC0, 0X1C80, 0XDC41,
    0X1400, 0XD4C1, 0XD581, 0X1540, 0XD701, 0X17C0, 0X1680, 0XD641,
    0XD201, 0X12C0, 0X1380, 0XD341, 0X1100, 0XD1C1, 0XD081, 0X1040,
    0XF001, 0X30C0, 0X3180, 0XF141, 0X3300, 0XF3C1, 0XF281, 0X3240,
    0X3600, 0XF6C1, 0XF781, 0X3740, 0XF501, 0X35C0, 0X3480, 0XF441,
    0X3C00, 0XFCC1, 0XFD81, 0X3D40, 0XFF01, 0X3FC0, 0X3E80, 0XFE41,
    0XFA01, 0X3AC0, 0X3B80, 0XFB41, 0X3900, 0XF9C1, 0XF881, 0X3840,
    0X2800, 0XE8C1, 0XE981, 0X2940, 0XEB01, 0X2BC0, 0X2A80, 0XEA41,
    0XEE01, 0X2EC0, 0X2F80, 0XEF41, 0X2D00, 0XEDC1, 0XEC81, 0X2C40,
    0XE401, 0X24C0, 0X2580, 0XE541, 0X2700, 0XE7C1, 0XE681, 0X2640,
    0X2200, 0XE2C1, 0XE381, 0X2340, 0XE101, 0X21C0, 0X2080, 0XE041,
    0XA001, 0X60C0, 0X6180, 0XA141, 0X6300, 0XA3C1, 0XA281, 0X6240,
    0X6600, 0XA6C1, 0XA781, 0X6740, 0XA501, 0X65C0, 0X6480, 0XA441,
    0X6C00, 0XACC1, 0XAD81, 0X6D40, 0XAF01, 0X6FC0, 0X6E80, 0XAE41,
    0XAA01, 0X6AC0, 0X6B80, 0XAB41, 0X6900, 0XA9C1, 0XA881, 0X6840,
    0X7800, 0XB8C1, 0XB981, 0X7940, 0XBB01, 0X7BC0, 0X7A80, 0XBA41,
    0XBE01, 0X7EC0, 0X7F80, 0XBF41, 0X7D00, 0XBDC1, 0XBC81, 0X7C40,
    0XB401, 0X74C0, 0X7580, 0XB541, 0X7700, 0XB7C1, 0XB681, 0X7640,
    0X7200, 0XB2C1, 0XB381, 0X7340, 0XB101, 0X71C0, 0X7080, 0XB041,
    0X5000, 0X90C1, 0X9181, 0X5140, 0X9301, 0X53C0, 0X5280, 0X9241,
    0X9601, 0X56C0, 0X5780, 0X9741, 0X5500, 0X95C1, 0X9481, 0X5440,
    0X9C01, 0X5CC0, 0X5D80, 0X9D41, 0X5F00, 0X9FC1, 0X9E81, 0X5E40,
    0X5A00, 0X9AC1, 0X9B81, 0X5B40, 0X9901, 0X59C0, 0X5880, 0X9841,
    0X8801, 0X48C0, 0X4980, 0X8941, 0X4B00, 0X8BC1, 0X8A81, 0X4A40,
    0X4E00, 0X8EC1, 0X8F81, 0X4F40, 0X8D01, 0X4DC0, 0X4C80, 0X8C41,
    0X4400, 0X84C1, 0X8581, 0X4540, 0X8701, 0X47C0, 0X4680, 0X8641,
    0X8201, 0X42C0, 0X4380, 0X8341, 0X4100, 0X81C1, 0X8081, 0X4040
};
    string decodeModbusMsgRTU(int direction, Boolean RTU,  string msg)
    {
      if (msg.Length < 7) return "invalid format, message too short";
      if (msg.Substring(0, 1) != ":") return "invalid format, should start with \":\"";
      msg = msg.Substring(1);
      if (msg.Length % 2 == 1) return "invalid format, characters count should be odd.";
      int len = msg.Length >> 1;
      Byte[] data = new byte[len];
      for (int i = 0; i < len; i++)
      {
        string b = msg.Substring(2 * i, 2);
        try
        {
          data[i] = (byte)int.Parse(b, System.Globalization.NumberStyles.HexNumber);
        }
        catch (Exception) { return "invalid format, " + b + " is not a valid Hexadecimal value."; }
      }

      if (RTU)   // RTUCRC
      {
        ushort CRCWord = 0xFFFF;
        for (int i = 0; i < len - 2; i++)
        {
          byte temp = (byte)(data[i] ^ (byte)CRCWord);
          CRCWord >>= 8;
          CRCWord ^= modbusCRCTable[temp];
        }

        ushort msgcrc = (ushort)(data[len - 2] | ((ushort)data[len - 1]) << 8);
        if (CRCWord != msgcrc) { return "bad RTU CRC, expected " + CRCWord.ToString("X4") + ", got " + msgcrc.ToString("X4"); }
      }
      else
      {
        sbyte total = 0;
        for (int i = 0; i < len - 1; i++) total += (sbyte)data[i];
      
        byte checksum = (byte)(-total);
        if  (checksum!= (byte)data[len - 1]) { return "bad ASCII checksum, expected " + checksum.ToString("X2") + ", got " + data[len - 1].ToString("X2"); }

      }


      byte fct = data[1];

      String Error = "unknown error code (" + (fct & 0x0f).ToString() + ")";
      if ((fct & 0xf0) ==0x80)
      {  switch (data[2])
        {
          case 1: Error = "ILLEGAL FUNCTION"; break;
          case 2: Error = "ILLEGAL DATA ADDRESS"; break;
          case 3: Error = "ILLEGAL DATA VALUE"; break;
          case 4: Error = "SERVER DEVICE FAILURE"; break;
          case 5: Error = "ACKNOWLEDGE"; break;
          case 6: Error = "SERVER DEVICE BUSY"; break;
          case 8: Error = "MEMORY PARITY ERROR"; break;
          case 10: Error = "GATEWAY PATH UNAVAILABLE"; break;
          case 11: Error = "GATEWAY TARGET DEVICE"; break;
        }
      }
      // coils  && inputbits read operations
      if (((fct & 0x5f) == 1) || ((fct & 0x5f) == 2))
      { string what = (fct & 0x5f) == 1 ? "coil":"input bit";
        if ((fct & 0x80) == 0x80) return what+" read error: " + Error;
        if (len == 8 - (RTU?0:1) ) 
        {
          ushort start = (ushort)(((ushort)data[2] << 8) | data[3]);
          ushort count = (ushort)(((ushort)data[4] << 8) | data[5]);
          return "read " + count.ToString() + " "+what+"(s), starting from index " + start;
        }
        else
        {
          String res = "read "+what+"s response : ";
          int qty = data[2] *8; 
          for (int i = 0; i < qty; i++)
          {
            int index = (i >> 3) + 3;
            int mask = 1 << (i & 7);
            if ((i & 0x7) == 0) res = res + "(";
            if (mask != 1) res = res + ",";
            res += ((data[index] & mask) != 0) ? "1" : "0";
            if ((i & 0x7) == 7) res = res + ")";
          }
          if (res.Substring(res.Length - 1) != ")") res = res + ")";


        
          return res;
        }
      }

     

        // coils write  operations
        if ((fct & 0x5f) == 5)
      {
        if ((fct & 0x80) == 0x80) return "coil write error: " + Error;
        ushort coil = (ushort)(((ushort)data[2] << 8) | data[3]);
        ushort value = (ushort)(((ushort)data[4] << 8) | data[5]);
        if (direction ==0) return "set coil " + coil.ToString() + " to " + (value > 0 ? "1" : "0");
               else return "coil " + coil.ToString() + " has been set to " + (value > 0 ? "1" : "0") +" (could be a write request as well)";
        
      }


      // input/holding registers read operations
      if (((fct & 0x5f) == 3) || ((fct & 0x5f) == 4))
      {
        string what = (fct & 0x0f) == 4 ? "input register" : "holding register";
        if ((fct & 0x80) == 0x80) return what + " read error: " + Error;
        if (len == 8 - (RTU ? 0 : 1))
        {
          ushort start = (ushort)(((ushort)data[2] << 8) | data[3]);
          ushort count = (ushort)(((ushort)data[4] << 8) | data[5]);
          return "read " + count.ToString() + " " + what + "(s), starting from index " + start;
        }
        else
        {
          String res = "read " + what + "s response : ";
          int count = data[2] / 2;
          for (int i = 0; i < count; i++)
          {
            ushort  v = (ushort)(((ushort)data[3+2*i] << 8) | data[4 + 2 * i]);
            res += (i > 0 ? " , " : "") + v.ToString()+" (0x"+v.ToString("X4")+")";

          }
          return res;
        }
      }


      // Write Single Register
      if ((fct & 0x5f) == 6)
      {
        if ((fct & 0x80) == 0x80) return "single register write error: " + Error;
      
        ushort register = (ushort)(((ushort)data[2] << 8) | data[3]);
        ushort value = (ushort)(((ushort)data[4] << 8) | data[5]);
        if (direction == 0) return "set holding register  " + register.ToString() + " to " + value.ToString();
        else return "holding register " + register.ToString() + " has been set to " + value.ToString() + " (could be a write request as well)";
      }




      // read exception 
      if ((fct & 0x5f) == 7)
      {
        if ((fct & 0x80) == 0x80) return   "exception status read error: " + Error;
        if (len == 1) return "read exception status";
        return "exception status = "+data[2].ToString();


      }

      // Write Multiple Coils
      if ((fct & 0x0f) == 15)
      {
        if ((fct & 0x80) == 0x80) return "Write multiple coils error: " + Error;
        ushort start = (ushort)(((ushort)data[2] << 8) | data[3]);
        ushort qty = (ushort)(((ushort)data[4] << 8) | data[5]);
        if (len == 8 - (RTU ? 0 : 1))
        {  return qty.ToString()+" coil(s) have been set, starting from from index " + start.ToString();
        }
        string res =  "writing "+ qty.ToString() + " coil(s)  starting from index " + start.ToString()+", values=";
        for (int i = 0; i < qty; i++)
        { int index = (i >> 3) + 7;
          int mask = 1 << (i & 7);
          if ((i & 0x7) == 0)  res = res + "(";
          if (mask != 1) res = res + ",";
          res += ((data[index] & mask) != 0) ? "1" : "0";         
          if ((i & 0x7) == 7) res = res + ")";
        }
        if (res.Substring(res.Length-1) !=")") res = res + ")";
        return res;
      }

      // Write Multiple Registers
      if ((fct & 0x5f) == 16)
      {
        if ((fct & 0x80) == 0x80) return "Write multiple resgisters error: " + Error;
        ushort start = (ushort)(((ushort)data[2] << 8) | data[3]);
        ushort qty = (ushort)(((ushort)data[4] << 8) | data[5]);
        if (len == 8 - (RTU ? 0 : 1))
        {
          return qty.ToString() + " registers(s) set, starting from index " + start.ToString();
        }
        string res = "writing " + qty.ToString() + " registers(s)  starting from index " + start.ToString() + ", values=(";
        for (int i = 0; i < qty; i++)
        {
          ushort v = (ushort)(((ushort)data[7+2*i] << 8) | data[8+2*i]);
          res = res + (i > 0 ? "," : "");
          res = res + v.ToString();
            
        }
       res = res + ")";
       return res;
      }
      return "Unable do decode";

    }


    // set device MODBUS protocol
    private void Protocol_SelectedIndexChanged(object sender, EventArgs e)
    {
      StopScan = true;
      if (disableUpdatecallback) return;
      if (interfaceChooser.SelectedIndex < 0) return;
      YSerialPort p = ((PortItem)interfaceChooser.SelectedItem).port;
      if (!p.isOnline()) return;
      String sProtocol = Protocol.SelectedItem.ToString();
      p.set_protocol(sProtocol);
    }

    // sevice device MODBUS speed and parity
    private void Speed_SelectedIndexChanged(object sender, EventArgs e)
    {
      StopScan = true;
      if (disableUpdatecallback) return;
      if (Speed.SelectedIndex < 0) return;
      if (Parity.SelectedIndex < 0) return;
      YSerialPort p = ((PortItem)interfaceChooser.SelectedItem).port;
      if (!p.isOnline()) return;
      String serialMode = Speed.SelectedItem.ToString() + "," + Parity.SelectedItem.ToString();
      p.set_serialMode(serialMode);
    }

    // someone has clicked on the scan for slaves button 
    private void scanForSlave_btn_Click(object sender, EventArgs e)
    {
      scanlabel.Text = "Scanning, please wait...";
      Application.DoEvents();

      List<int> addr = StartNewModbusScan();
      if (addr == null) return;
      if (addr.Count == 0) scanlabel.Text = "Nothing found (doesn't mean there is nothing though)";
      else if (addr.Count == 1)
      {
        scanlabel.Text = "One slave found at address " + addr[0].ToString();
        if (slaveAddr.Text == "") slaveAddr.Text = addr[0].ToString();
      }
      else
      {
        string msg = addr.Count.ToString() + " slaves found at addresses 0x" + addr[0].ToString();
        for (int i = 1; i < addr.Count; i++) msg += ", 0x" + String.Format("{0:X02}", addr[i].ToString());

      }
    }

    
    private void readCoil_btn_Click(object sender, EventArgs e)
    {
      int address = inputValue(slaveAddr, 1, 247);
      int coil = inputValue(CoilNumber, 0, 9999);

      string cmd = "calling YSerialPort.modbusReadBits(" + address.ToString() + "," + coil.ToString() + ",1) ";
      try
      { List<int> values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadBits(address, coil, 1);
        coilValue.Text = values[0].ToString();
        ReadCoilResult.Text = "Read operation sucessfull";
        cmd +=" SUCCESS ("+ values[0].ToString()+")";
      }
      catch (Exception ex)
      { ReadCoilResult.Text = "Read operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
      }
      log(cmd);

    }

    private void writeCoil_btn_Click(object sender, EventArgs e)
    { int address = inputValue(slaveAddr, 1, 247);
      int coildindex = inputValue(CoilNumber, 0, 9999);
      int value = inputValue(coilWriteValue, 0, 1);
      Boolean ok = false;
      string cmd = "calling YSerialPort.modbusWriteBit(" + address.ToString() + "," + coildindex.ToString() + "," + value.ToString() + ") ";
      try
      {
        ((PortItem)interfaceChooser.SelectedItem).port.modbusWriteBit(address, coildindex, value );
       
        ok = true;
        ReadCoilResult.Text = "Write operation sucessfull"; 
        cmd += " SUCCESS";
      }
      catch (Exception ex)
      {
        ReadCoilResult.Text = "Write operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
      }
      log(cmd);
      if (ok) readCoil_btn_Click(null, null);
    }

    private void readInputBits_btn_Click(object sender, EventArgs e)
    {
      int address = inputValue(slaveAddr, 1, 247);
      int inputBit = inputValue(inputbitsIndex, 0, 9999);
      string cmd = "calling YSerialPort.modbusReadInputBits(" + address.ToString() + "," + inputBit.ToString() + ",1) ";
      try
      {
        List<int> values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadInputBits(address, inputBit, 1);
        inputBitsValue.Text = values[0].ToString();
        ReadInputBitResult.Text = "Read operation sucessfull";
        cmd += " SUCCESS (" + values[0].ToString() + ")";
      }
      catch (Exception ex)
      { ReadInputBitResult.Text = "Read operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
       
      }
      log(cmd);
    }

    private void readInputRegisters_btn_Click(object sender, EventArgs e)
    {
      int address = inputValue(slaveAddr, 1, 247);
      int inputregisters = inputValue(InputRegistersIndex, 0, 9999);
      string cmd = "calling YSerialPort.modbusReadInputRegisters(" + address.ToString() + "," + inputregisters.ToString() + ",1) ";
     
      try
      {
        List<int> values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadInputRegisters(address, inputregisters, 1);
        inputRegistersValues.Text = values[0].ToString();
        ReadInputRegisterResult.Text = "Read operation sucessfull";
        cmd += " SUCCESS (" + values[0].ToString() + ")";
      }
      catch (Exception ex)
      { ReadInputRegisterResult.Text = "Read operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
      }
      log(cmd);

    }

    private void readHoldingRegisters_btn_Click(object sender, EventArgs e)
    {
      int address = inputValue(slaveAddr, 1, 247);
      int HoldingRegisters = inputValue(HoldingRegistersIndex, 0, 9999);
      string cmd = "calling YSerialPort.modbusReadRegisters(" + address.ToString() + "," + HoldingRegisters.ToString() + ",1) ";
      try
      {
        List<int> values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadRegisters(address, HoldingRegisters, 1);
        HoldingRegistersReadValue.Text = values[0].ToString();
        HoldingRegistersOperationResult.Text = "Read operation sucessfull";
        cmd += " SUCCESS (" + values[0].ToString() + ")";
      }
      catch (Exception ex)
      {
        HoldingRegistersOperationResult.Text = "Read operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
      }
      log(cmd);
    }

    private void writeHoldingRegisters_btn_Click(object sender, EventArgs e)
    {

      int address = inputValue(slaveAddr, 1, 247);
      int HoldingRegisters = inputValue(HoldingRegistersIndex, 0, 9999);
      int value = inputValue(HoldingRegistersWriteValue, 0, 65535);
      string cmd = "calling YSerialPort.modbusWriteRegisters(" + address.ToString() +"," + HoldingRegisters .ToString()+  ", new List<int>{" + value + "}) ";
      Boolean ok = false;
      try
      {
        ((PortItem)interfaceChooser.SelectedItem).port.modbusWriteRegisters(address, HoldingRegisters, new List<int> { value });
        ok = true;
        HoldingRegistersOperationResult.Text = "Write operation sucessfull";
        cmd += " SUCCESS";
      }
      catch (Exception ex)
      { HoldingRegistersOperationResult.Text = "Write operation failed (" + ex.Message + ")";
        cmd += " FAILED (" + ex.Message + ")";
      }
      log(cmd);
      if (ok) readHoldingRegisters_btn_Click(null, null);
    }

    // Convert a textbox contents to ant integer and checks if this integer
    // is within a specified range. Accepts both decimal and hexadecimal syntax
    private int inputValue(TextBox source, int minValue, int maxValue)
    {
      Boolean ok = true;
      int value = -1;
      String v = source.Text;
      if ((v.Length > 2) && (v.Substring(0, 2).ToUpper() == "0X"))
      {
        try
        {
          value = int.Parse(v.Substring(2), System.Globalization.NumberStyles.HexNumber);

        }
        catch (Exception ) { ok = false; }
      }
      else
      {
        try
        { value = int.Parse(v); }
        catch (Exception ) { ok = false; }
      }
      if ((value < minValue) || (value > maxValue)) { ok = false; value = -1; }

      source.BackColor = ok ? SystemColors.Window : Color.Pink;
      return value;
    }

    // automatically enable / disable coils controls
    private void checkCoilControls(Boolean overideToFalse)
    {
      Boolean validIndex = (inputValue(CoilNumber, 0, 9999) >= 0);
      CoilNumber.Enabled = !overideToFalse;
      StartCoilsScan_btn.Enabled = !overideToFalse;
      readCoil_btn.Enabled = (!overideToFalse) && (validIndex);

      Boolean validValue = (inputValue(coilWriteValue, 0, 1) >= 0);
      coilWriteValue.Enabled = !overideToFalse && validIndex;
      writeCoil2_btn.Enabled = (!overideToFalse) && (validIndex) && validValue;
      StartCoilsScan_btn.Enabled = (!overideToFalse) && (validIndex);


    }
    // automatically enable / disable input bits controls
    private void checkInputBitsControls(Boolean overideToFalse)
    {
      Boolean validInput = (inputValue(inputbitsIndex, 0, 9999) >= 0);
      inputbitsIndex.Enabled = !overideToFalse;
      readInputBit.Enabled = (!overideToFalse) && (validInput);
      StartInputBitsScan_btn.Enabled = !overideToFalse;
    }

    // automatically enable / disable input register  controls
    private void checkInputRegistersControls(Boolean overideToFalse)
    {
      Boolean validInput = (inputValue(inputbitsIndex, 0, 9999) >= 0);
      inputbitsIndex.Enabled = !overideToFalse;
      readInputRegisters_btn.Enabled = (!overideToFalse) && (validInput);
      StartInputRegistersScan_btn.Enabled = !overideToFalse;
    }

    // automatically enable / disable holding register controls

    private void checkHolderRegistersControls(Boolean overideToFalse)
    {
      Boolean validIndex = (inputValue(HoldingRegistersIndex, 0, 9999) >= 0);
      Boolean validValue = (inputValue(HoldingRegistersWriteValue, 0, 65535) >= 0);
      Boolean startvalueValue = (inputValue(HoldingRegistersScanFrom, 0, 65535) >= 0);
      HoldingRegistersIndex.Enabled = !overideToFalse;
      HoldingRegistersWriteValue.Enabled = !overideToFalse && validIndex;
      readHoldingRegisters_btn.Enabled = (!overideToFalse) && (validIndex);
      writeHoldingRegisters_btn.Enabled = (!overideToFalse) && (validIndex) && validValue;
      HoldingRegistersScanFrom.Enabled = !overideToFalse && startvalueValue;
      StartHoldingRegistersScan_btn.Enabled = !overideToFalse;
    }

    // someone chenged the slave's address parameter, enable/disable
    // the ui accordindly
    private void slaveAddr_TextChanged(object sender, EventArgs e)
    { bool ok = (inputValue(slaveAddr, 1, 247) >= 0);
      StopScan = true;
      slaveAddr.BackColor = ok ? SystemColors.Window : Color.Pink;
      checkCoilControls(!ok);
      checkInputBitsControls(!ok);
      checkInputRegistersControls(!ok);
      checkHolderRegistersControls(!ok);
    }  

    private void CoilNumber_TextChanged(object sender, EventArgs e)
    {
      checkCoilControls(false);
    }

    private void inputbitsIndex_TextChanged(object sender, EventArgs e)
    {
      checkInputBitsControls(false);
    }

    private void InputRegistersIndex_TextChanged(object sender, EventArgs e)
    {
      checkInputRegistersControls(false);
    }

    private void HoldingRegistersIndex_TextChanged(object sender, EventArgs e)
    {
      checkHolderRegistersControls(false);

    }

    private void HoldingRegistersWriteValue_TextChanged(object sender, EventArgs e)
    {
      checkHolderRegistersControls(false);
    }

    bool StopScan = true;

    private enum scanTypes  { COILS, INPUTBITS, INPUTREGISTERS, HOLDINGREGISTERS };
    // start a scan for coils contents
    private void StartCoilsScan_btn_Click(object sender, EventArgs e)
    {
      GenericScan(scanTypes.COILS, CoilValuesGrid, coilScanProgess, coilScanMessage, StartCoilsScan_btn,null);
    }
    // start a scan for holding registers contents
    private void StartHoldingRegistersScan_btn_Click(object sender, EventArgs e)
    {
      GenericScan(scanTypes.HOLDINGREGISTERS, HoldingRegistersValuesGrid, HoldingRegistersScanProgess, HoldingRegistersMessage, StartHoldingRegistersScan_btn, HoldingRegistersScanFrom);
    }
    // start a scan for inputbit  contents
    private void StartInputBitsScan_btn_Click(object sender, EventArgs e)
    {
      GenericScan (scanTypes.INPUTBITS, InputBitsValuesGrid,  inputBitsScanProgess, InputBitsScanMessage, StartInputBitsScan_btn,null);
    }
    // start a scan for input registers  contents
    private void StartInputRegistersScan_btn_Click(object sender, EventArgs e)
    {
      GenericScan(scanTypes.INPUTREGISTERS, InputRegistersValuesGrid, InputRegistersScanProgess, InputRegistersScanMessage, StartInputRegistersScan_btn, null);
    }

    // Generic scan function for contents of coils, holding registers , input bits, input registers .

    private void GenericScan(scanTypes scantype, DataGridView resultGrid, ProgressBar scanProgess, Label ScanMsg, Button ScanButton, TextBox startFrom )
    {
      
      if  (!StopScan)
      {
        StopScan = true;
        return;
      }
      int address = inputValue(slaveAddr, 1, 247);

      int i = startFrom!=null ? inputValue(startFrom, 0, 65535) : 0;

      string Errmsg="";
      resultGrid.Rows.Clear();
      StopScan = false;
      
      int count = 0;
      ScanButton.Text = "Stop";
      scanProgess.Visible = true;
      String item = "";
      while ((i < 9999) && (!StopScan))
      {
       
        try
        {
          List<int> values =null;
          ScanMsg.Text = "Scanning"+item+ " " + i.ToString();
          
          switch (scantype)
          { case scanTypes.COILS:
              item = "coil";
              values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadBits(address, i, 1); break;
            case scanTypes.INPUTBITS: item = "input bit";
              values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadInputBits(address, i, 1);
              break; 
            case scanTypes.INPUTREGISTERS:
              item = "input register";
              values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadInputRegisters(address, i, 1);
              break;
            case scanTypes.HOLDINGREGISTERS:
              item = "holding register";
              values = ((PortItem)interfaceChooser.SelectedItem).port.modbusReadRegisters(address, i, 1);
              break; 
          }
      
          int index = resultGrid.Rows.Add();
          resultGrid.Rows[index].Cells[0].Value = i.ToString();
          resultGrid.Rows[index].Cells[1].Value = values[0].ToString();

          resultGrid.Rows[index].Cells[2].Value = i.ToString("X4");
          resultGrid.Rows[index].Cells[3].Value = values[0].ToString("X4");
          count++;

        }
        catch (Exception e)
        { String msg = e.Message; }
        i++;
        scanProgess.Value = (100 * i / 9999);
        YAPI.Sleep(1, ref Errmsg);
        Application.DoEvents();
      }
      scanProgess.Visible = false;
      String line = StopScan ? "Scan stopped, " : "Scan done, ";
      if (count == 0) line += "no ";
      else if (count == 1) line += "one ";
      else line += count.ToString() + " ";
      line += item + ((count > 1) ? "s" : "" )+" found";
      if (StopScan) line += " so far";
      line += ".";
      ScanMsg.Text = line;

    ScanButton.Text = "Start";
    }
    // opens a web browser on Yoctopuce's web site.
    private void label21_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.yoctopuce.com/EN/article/a-quick-tutorial-on-rs485-and-modbus");
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void ClearSnoopingLogs_btn_Click(object sender, EventArgs e)
    {
      ClearSnoopingLogs();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      YAPI.FreeAPI();  // will also kill the call back
    }

    private void cpyToClipBoard_btn_Click(object sender, EventArgs e)
    {
      string res = "";
      int colCount = SnoopingContents.Columns.Count;
      for (int i = 0; i < colCount; i++) res = res + (i > 0 ? "\t" : "") + SnoopingContents.Columns[i].HeaderText;
      res += "\r\n";
      for (int j=0;j< SnoopingContents.Rows.Count;j++)
      {
        for (int i = 0; i < colCount; i++)
        {
          if (i == 1) res = res + '\t' + ((string)SnoopingContents.Rows[j].Cells[1].Value == char.ConvertFromUtf32(0x2190) ? "<-" : "->");
          else res = res + (i > 0 ? "\t" : "") + SnoopingContents.Rows[j].Cells[i].Value;
        }
        res += "\r\n";
      }

     Clipboard.SetText(res, System.Windows.Forms.TextDataFormat.Text );
    }
  }

  
  
}



