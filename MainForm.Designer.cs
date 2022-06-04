namespace RS485tool
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label1 = new System.Windows.Forms.Label();
      this.interfaceChooser = new System.Windows.Forms.ComboBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.Protocol = new System.Windows.Forms.ComboBox();
      this.Speed = new System.Windows.Forms.ComboBox();
      this.Parity = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textlogs = new System.Windows.Forms.TextBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.slaveAddr = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.CoilNumber = new System.Windows.Forms.TextBox();
      this.readCoil_btn = new System.Windows.Forms.Button();
      this.coilValue = new System.Windows.Forms.TextBox();
      this.inputBitsValue = new System.Windows.Forms.TextBox();
      this.readInputBit = new System.Windows.Forms.Button();
      this.inputbitsIndex = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.inputRegistersValues = new System.Windows.Forms.TextBox();
      this.readInputRegisters_btn = new System.Windows.Forms.Button();
      this.InputRegistersIndex = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.HoldingRegistersReadValue = new System.Windows.Forms.TextBox();
      this.readHoldingRegisters_btn = new System.Windows.Forms.Button();
      this.HoldingRegistersIndex = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.HoldingRegistersWriteValue = new System.Windows.Forms.TextBox();
      this.writeHoldingRegisters_btn = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      this.writeCoil_btn = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.coilWriteValue = new System.Windows.Forms.TextBox();
      this.label22 = new System.Windows.Forms.Label();
      this.writeCoil2_btn = new System.Windows.Forms.Button();
      this.coilScanProgess = new System.Windows.Forms.ProgressBar();
      this.label11 = new System.Windows.Forms.Label();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.StartCoilsScan_btn = new System.Windows.Forms.Button();
      this.coilScanMessage = new System.Windows.Forms.Label();
      this.CoilValuesGrid = new System.Windows.Forms.DataGridView();
      this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.indexHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.valueHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ReadCoilResult = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.inputBitsScanProgess = new System.Windows.Forms.ProgressBar();
      this.label13 = new System.Windows.Forms.Label();
      this.StartInputBitsScan_btn = new System.Windows.Forms.Button();
      this.InputBitsScanMessage = new System.Windows.Forms.Label();
      this.InputBitsValuesGrid = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ReadInputBitResult = new System.Windows.Forms.Label();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.pictureBox6 = new System.Windows.Forms.PictureBox();
      this.InputRegistersScanProgess = new System.Windows.Forms.ProgressBar();
      this.label14 = new System.Windows.Forms.Label();
      this.StartInputRegistersScan_btn = new System.Windows.Forms.Button();
      this.InputRegistersScanMessage = new System.Windows.Forms.Label();
      this.InputRegistersValuesGrid = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ReadInputRegisterResult = new System.Windows.Forms.Label();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.label23 = new System.Windows.Forms.Label();
      this.HoldingRegistersScanFrom = new System.Windows.Forms.TextBox();
      this.HoldingRegistersScanProgess = new System.Windows.Forms.ProgressBar();
      this.label12 = new System.Windows.Forms.Label();
      this.StartHoldingRegistersScan_btn = new System.Windows.Forms.Button();
      this.HoldingRegistersMessage = new System.Windows.Forms.Label();
      this.HoldingRegistersValuesGrid = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.HoldingRegistersOperationResult = new System.Windows.Forms.Label();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.cpyToClipBoard_btn = new System.Windows.Forms.Button();
      this.ClearSnoopingLogs_btn = new System.Windows.Forms.Button();
      this.SnoopingContents = new System.Windows.Forms.DataGridView();
      this.label24 = new System.Windows.Forms.Label();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.scanlabel = new System.Windows.Forms.Label();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BuildNumber_label = new System.Windows.Forms.Label();
      this.writeCoil_btn.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CoilValuesGrid)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.InputBitsValuesGrid)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.InputRegistersValuesGrid)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.HoldingRegistersValuesGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.tabPage6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SnoopingContents)).BeginInit();
      this.tabPage5.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(141, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Available Modbus Interfaces";
      // 
      // interfaceChooser
      // 
      this.interfaceChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.interfaceChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.interfaceChooser.FormattingEnabled = true;
      this.interfaceChooser.Location = new System.Drawing.Point(155, 64);
      this.interfaceChooser.Name = "interfaceChooser";
      this.interfaceChooser.Size = new System.Drawing.Size(301, 21);
      this.interfaceChooser.TabIndex = 1;
      this.interfaceChooser.SelectedIndexChanged += new System.EventHandler(this.interfaceChooser_SelectedIndexChanged);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Protocol
      // 
      this.Protocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Protocol.FormattingEnabled = true;
      this.Protocol.Items.AddRange(new object[] {
            "Modbus-RTU",
            "Modbus-ASCII"});
      this.Protocol.Location = new System.Drawing.Point(155, 91);
      this.Protocol.Name = "Protocol";
      this.Protocol.Size = new System.Drawing.Size(301, 21);
      this.Protocol.TabIndex = 2;
      this.Protocol.SelectedIndexChanged += new System.EventHandler(this.Protocol_SelectedIndexChanged);
      // 
      // Speed
      // 
      this.Speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Speed.FormattingEnabled = true;
      this.Speed.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
      this.Speed.Location = new System.Drawing.Point(155, 118);
      this.Speed.Name = "Speed";
      this.Speed.Size = new System.Drawing.Size(189, 21);
      this.Speed.TabIndex = 3;
      this.Speed.SelectedIndexChanged += new System.EventHandler(this.Speed_SelectedIndexChanged);
      // 
      // Parity
      // 
      this.Parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Parity.FormattingEnabled = true;
      this.Parity.Items.AddRange(new object[] {
            "8N1",
            "8E1",
            "8O1",
            "8N2",
            "7E1"});
      this.Parity.Location = new System.Drawing.Point(389, 118);
      this.Parity.Name = "Parity";
      this.Parity.Size = new System.Drawing.Size(67, 21);
      this.Parity.TabIndex = 4;
      this.Parity.SelectedIndexChanged += new System.EventHandler(this.Speed_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 94);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Protocol";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Speed";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(350, 121);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Parity";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(377, 208);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Scan";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.scanForSlave_btn_Click);
      // 
      // textlogs
      // 
      this.textlogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textlogs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textlogs.Location = new System.Drawing.Point(3, 3);
      this.textlogs.Multiline = true;
      this.textlogs.Name = "textlogs";
      this.textlogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textlogs.Size = new System.Drawing.Size(428, 306);
      this.textlogs.TabIndex = 10;
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.Location = new System.Drawing.Point(13, 209);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(358, 22);
      this.progressBar1.TabIndex = 12;
      // 
      // slaveAddr
      // 
      this.slaveAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.slaveAddr.Location = new System.Drawing.Point(350, 257);
      this.slaveAddr.Name = "slaveAddr";
      this.slaveAddr.Size = new System.Drawing.Size(100, 20);
      this.slaveAddr.TabIndex = 15;
      this.slaveAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.slaveAddr.TextChanged += new System.EventHandler(this.slaveAddr_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 260);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(168, 13);
      this.label5.TabIndex = 16;
      this.label5.Text = "Modubus device address: (1..247)";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(10, 19);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(27, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "Coil:";
      // 
      // CoilNumber
      // 
      this.CoilNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CoilNumber.Location = new System.Drawing.Point(78, 16);
      this.CoilNumber.Name = "CoilNumber";
      this.CoilNumber.Size = new System.Drawing.Size(104, 20);
      this.CoilNumber.TabIndex = 18;
      this.CoilNumber.Text = "0";
      this.CoilNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.CoilNumber.TextChanged += new System.EventHandler(this.CoilNumber_TextChanged);
      // 
      // readCoil_btn
      // 
      this.readCoil_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.readCoil_btn.Location = new System.Drawing.Point(215, 14);
      this.readCoil_btn.Name = "readCoil_btn";
      this.readCoil_btn.Size = new System.Drawing.Size(75, 23);
      this.readCoil_btn.TabIndex = 19;
      this.readCoil_btn.Text = "read";
      this.readCoil_btn.UseVisualStyleBackColor = true;
      this.readCoil_btn.Click += new System.EventHandler(this.readCoil_btn_Click);
      // 
      // coilValue
      // 
      this.coilValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.coilValue.Location = new System.Drawing.Point(333, 16);
      this.coilValue.Name = "coilValue";
      this.coilValue.ReadOnly = true;
      this.coilValue.Size = new System.Drawing.Size(72, 20);
      this.coilValue.TabIndex = 20;
      this.coilValue.Text = "-";
      this.coilValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // inputBitsValue
      // 
      this.inputBitsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.inputBitsValue.Location = new System.Drawing.Point(356, 16);
      this.inputBitsValue.Name = "inputBitsValue";
      this.inputBitsValue.ReadOnly = true;
      this.inputBitsValue.Size = new System.Drawing.Size(72, 20);
      this.inputBitsValue.TabIndex = 24;
      this.inputBitsValue.Text = "-";
      this.inputBitsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // readInputBit
      // 
      this.readInputBit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.readInputBit.Location = new System.Drawing.Point(257, 13);
      this.readInputBit.Name = "readInputBit";
      this.readInputBit.Size = new System.Drawing.Size(75, 23);
      this.readInputBit.TabIndex = 23;
      this.readInputBit.Text = "read";
      this.readInputBit.UseVisualStyleBackColor = true;
      this.readInputBit.Click += new System.EventHandler(this.readInputBits_btn_Click);
      // 
      // inputbitsIndex
      // 
      this.inputbitsIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.inputbitsIndex.Location = new System.Drawing.Point(128, 15);
      this.inputbitsIndex.Name = "inputbitsIndex";
      this.inputbitsIndex.Size = new System.Drawing.Size(100, 20);
      this.inputbitsIndex.TabIndex = 22;
      this.inputbitsIndex.Text = "0";
      this.inputbitsIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.inputbitsIndex.TextChanged += new System.EventHandler(this.inputbitsIndex_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 18);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 13);
      this.label7.TabIndex = 21;
      this.label7.Text = "Input bits:";
      // 
      // inputRegistersValues
      // 
      this.inputRegistersValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.inputRegistersValues.Location = new System.Drawing.Point(349, 16);
      this.inputRegistersValues.Name = "inputRegistersValues";
      this.inputRegistersValues.ReadOnly = true;
      this.inputRegistersValues.Size = new System.Drawing.Size(72, 20);
      this.inputRegistersValues.TabIndex = 28;
      this.inputRegistersValues.Text = "-";
      this.inputRegistersValues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // readInputRegisters_btn
      // 
      this.readInputRegisters_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.readInputRegisters_btn.Location = new System.Drawing.Point(266, 14);
      this.readInputRegisters_btn.Name = "readInputRegisters_btn";
      this.readInputRegisters_btn.Size = new System.Drawing.Size(75, 23);
      this.readInputRegisters_btn.TabIndex = 27;
      this.readInputRegisters_btn.Text = "read";
      this.readInputRegisters_btn.UseVisualStyleBackColor = true;
      this.readInputRegisters_btn.Click += new System.EventHandler(this.readInputRegisters_btn_Click);
      // 
      // InputRegistersIndex
      // 
      this.InputRegistersIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InputRegistersIndex.Location = new System.Drawing.Point(132, 16);
      this.InputRegistersIndex.Name = "InputRegistersIndex";
      this.InputRegistersIndex.Size = new System.Drawing.Size(100, 20);
      this.InputRegistersIndex.TabIndex = 26;
      this.InputRegistersIndex.Text = "0";
      this.InputRegistersIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.InputRegistersIndex.TextChanged += new System.EventHandler(this.InputRegistersIndex_TextChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(10, 19);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(76, 13);
      this.label8.TabIndex = 25;
      this.label8.Text = "Input registers:";
      // 
      // HoldingRegistersReadValue
      // 
      this.HoldingRegistersReadValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersReadValue.Location = new System.Drawing.Point(354, 15);
      this.HoldingRegistersReadValue.Name = "HoldingRegistersReadValue";
      this.HoldingRegistersReadValue.ReadOnly = true;
      this.HoldingRegistersReadValue.Size = new System.Drawing.Size(72, 20);
      this.HoldingRegistersReadValue.TabIndex = 32;
      this.HoldingRegistersReadValue.Text = "-";
      this.HoldingRegistersReadValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // readHoldingRegisters_btn
      // 
      this.readHoldingRegisters_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.readHoldingRegisters_btn.Location = new System.Drawing.Point(273, 13);
      this.readHoldingRegisters_btn.Name = "readHoldingRegisters_btn";
      this.readHoldingRegisters_btn.Size = new System.Drawing.Size(75, 23);
      this.readHoldingRegisters_btn.TabIndex = 31;
      this.readHoldingRegisters_btn.Text = "read";
      this.readHoldingRegisters_btn.UseVisualStyleBackColor = true;
      this.readHoldingRegisters_btn.Click += new System.EventHandler(this.readHoldingRegisters_btn_Click);
      // 
      // HoldingRegistersIndex
      // 
      this.HoldingRegistersIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersIndex.Location = new System.Drawing.Point(137, 14);
      this.HoldingRegistersIndex.Name = "HoldingRegistersIndex";
      this.HoldingRegistersIndex.Size = new System.Drawing.Size(104, 20);
      this.HoldingRegistersIndex.TabIndex = 30;
      this.HoldingRegistersIndex.Text = "0";
      this.HoldingRegistersIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.HoldingRegistersIndex.TextChanged += new System.EventHandler(this.HoldingRegistersIndex_TextChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(8, 17);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(86, 13);
      this.label9.TabIndex = 29;
      this.label9.Text = "holding registers:";
      // 
      // HoldingRegistersWriteValue
      // 
      this.HoldingRegistersWriteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersWriteValue.Location = new System.Drawing.Point(137, 45);
      this.HoldingRegistersWriteValue.Name = "HoldingRegistersWriteValue";
      this.HoldingRegistersWriteValue.Size = new System.Drawing.Size(104, 20);
      this.HoldingRegistersWriteValue.TabIndex = 33;
      this.HoldingRegistersWriteValue.Text = "0";
      this.HoldingRegistersWriteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.HoldingRegistersWriteValue.TextChanged += new System.EventHandler(this.HoldingRegistersWriteValue_TextChanged);
      // 
      // writeHoldingRegisters_btn
      // 
      this.writeHoldingRegisters_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.writeHoldingRegisters_btn.Location = new System.Drawing.Point(273, 42);
      this.writeHoldingRegisters_btn.Name = "writeHoldingRegisters_btn";
      this.writeHoldingRegisters_btn.Size = new System.Drawing.Size(75, 23);
      this.writeHoldingRegisters_btn.TabIndex = 34;
      this.writeHoldingRegisters_btn.Text = "write";
      this.writeHoldingRegisters_btn.UseVisualStyleBackColor = true;
      this.writeHoldingRegisters_btn.Click += new System.EventHandler(this.writeHoldingRegisters_btn_Click);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(58, 47);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(36, 13);
      this.label10.TabIndex = 35;
      this.label10.Text = "value:";
      // 
      // writeCoil_btn
      // 
      this.writeCoil_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.writeCoil_btn.Controls.Add(this.tabPage1);
      this.writeCoil_btn.Controls.Add(this.tabPage2);
      this.writeCoil_btn.Controls.Add(this.tabPage3);
      this.writeCoil_btn.Controls.Add(this.tabPage4);
      this.writeCoil_btn.Controls.Add(this.tabPage6);
      this.writeCoil_btn.Controls.Add(this.tabPage5);
      this.writeCoil_btn.Location = new System.Drawing.Point(10, 344);
      this.writeCoil_btn.Name = "writeCoil_btn";
      this.writeCoil_btn.SelectedIndex = 0;
      this.writeCoil_btn.Size = new System.Drawing.Size(446, 338);
      this.writeCoil_btn.TabIndex = 36;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.coilWriteValue);
      this.tabPage1.Controls.Add(this.label22);
      this.tabPage1.Controls.Add(this.writeCoil2_btn);
      this.tabPage1.Controls.Add(this.coilScanProgess);
      this.tabPage1.Controls.Add(this.label11);
      this.tabPage1.Controls.Add(this.pictureBox4);
      this.tabPage1.Controls.Add(this.StartCoilsScan_btn);
      this.tabPage1.Controls.Add(this.coilScanMessage);
      this.tabPage1.Controls.Add(this.CoilValuesGrid);
      this.tabPage1.Controls.Add(this.ReadCoilResult);
      this.tabPage1.Controls.Add(this.readCoil_btn);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.CoilNumber);
      this.tabPage1.Controls.Add(this.coilValue);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(438, 312);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Coils";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // coilWriteValue
      // 
      this.coilWriteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.coilWriteValue.Location = new System.Drawing.Point(141, 43);
      this.coilWriteValue.Name = "coilWriteValue";
      this.coilWriteValue.Size = new System.Drawing.Size(41, 20);
      this.coilWriteValue.TabIndex = 46;
      this.coilWriteValue.Text = "0";
      this.coilWriteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.coilWriteValue.TextChanged += new System.EventHandler(this.CoilNumber_TextChanged);
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(9, 46);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(63, 13);
      this.label22.TabIndex = 48;
      this.label22.Text = "Value (0/1):";
      // 
      // writeCoil2_btn
      // 
      this.writeCoil2_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.writeCoil2_btn.Location = new System.Drawing.Point(214, 41);
      this.writeCoil2_btn.Name = "writeCoil2_btn";
      this.writeCoil2_btn.Size = new System.Drawing.Size(75, 23);
      this.writeCoil2_btn.TabIndex = 47;
      this.writeCoil2_btn.Text = "write";
      this.writeCoil2_btn.UseVisualStyleBackColor = true;
      this.writeCoil2_btn.Click += new System.EventHandler(this.writeCoil_btn_Click);
      // 
      // coilScanProgess
      // 
      this.coilScanProgess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.coilScanProgess.Location = new System.Drawing.Point(150, 285);
      this.coilScanProgess.Name = "coilScanProgess";
      this.coilScanProgess.Size = new System.Drawing.Size(199, 20);
      this.coilScanProgess.TabIndex = 45;
      this.coilScanProgess.Visible = false;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(6, 111);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(324, 13);
      this.label11.TabIndex = 44;
      this.label11.Text = "You can also scan all coils for values, although this will take a while";
      // 
      // pictureBox4
      // 
      this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.pictureBox4.Location = new System.Drawing.Point(9, 96);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(412, 1);
      this.pictureBox4.TabIndex = 43;
      this.pictureBox4.TabStop = false;
      // 
      // StartCoilsScan_btn
      // 
      this.StartCoilsScan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.StartCoilsScan_btn.Location = new System.Drawing.Point(357, 285);
      this.StartCoilsScan_btn.Name = "StartCoilsScan_btn";
      this.StartCoilsScan_btn.Size = new System.Drawing.Size(75, 20);
      this.StartCoilsScan_btn.TabIndex = 42;
      this.StartCoilsScan_btn.Text = "Start";
      this.StartCoilsScan_btn.UseVisualStyleBackColor = true;
      this.StartCoilsScan_btn.Click += new System.EventHandler(this.StartCoilsScan_btn_Click);
      // 
      // coilScanMessage
      // 
      this.coilScanMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.coilScanMessage.AutoSize = true;
      this.coilScanMessage.Location = new System.Drawing.Point(10, 289);
      this.coilScanMessage.Name = "coilScanMessage";
      this.coilScanMessage.Size = new System.Drawing.Size(222, 13);
      this.coilScanMessage.TabIndex = 41;
      this.coilScanMessage.Text = "Click on Start to start scanning all coils values";
      // 
      // CoilValuesGrid
      // 
      this.CoilValuesGrid.AllowUserToAddRows = false;
      this.CoilValuesGrid.AllowUserToDeleteRows = false;
      this.CoilValuesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CoilValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.CoilValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.indexHex,
            this.col3,
            this.valueHex});
      this.CoilValuesGrid.Location = new System.Drawing.Point(7, 139);
      this.CoilValuesGrid.Name = "CoilValuesGrid";
      this.CoilValuesGrid.ReadOnly = true;
      this.CoilValuesGrid.RowHeadersVisible = false;
      this.CoilValuesGrid.Size = new System.Drawing.Size(425, 140);
      this.CoilValuesGrid.TabIndex = 40;
      // 
      // Index
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.Index.DefaultCellStyle = dataGridViewCellStyle1;
      this.Index.HeaderText = "Index";
      this.Index.Name = "Index";
      this.Index.ReadOnly = true;
      // 
      // indexHex
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.indexHex.DefaultCellStyle = dataGridViewCellStyle2;
      this.indexHex.HeaderText = "Value";
      this.indexHex.Name = "indexHex";
      this.indexHex.ReadOnly = true;
      // 
      // col3
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.col3.DefaultCellStyle = dataGridViewCellStyle3;
      this.col3.HeaderText = "Index (hex)";
      this.col3.Name = "col3";
      this.col3.ReadOnly = true;
      // 
      // valueHex
      // 
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.valueHex.DefaultCellStyle = dataGridViewCellStyle4;
      this.valueHex.HeaderText = "Value (hex)";
      this.valueHex.Name = "valueHex";
      this.valueHex.ReadOnly = true;
      // 
      // ReadCoilResult
      // 
      this.ReadCoilResult.AutoSize = true;
      this.ReadCoilResult.Location = new System.Drawing.Point(10, 71);
      this.ReadCoilResult.Name = "ReadCoilResult";
      this.ReadCoilResult.Size = new System.Drawing.Size(279, 13);
      this.ReadCoilResult.TabIndex = 21;
      this.ReadCoilResult.Text = "Enter a coil number (0..9999) and click on the read button";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.pictureBox5);
      this.tabPage2.Controls.Add(this.inputBitsScanProgess);
      this.tabPage2.Controls.Add(this.label13);
      this.tabPage2.Controls.Add(this.StartInputBitsScan_btn);
      this.tabPage2.Controls.Add(this.InputBitsScanMessage);
      this.tabPage2.Controls.Add(this.InputBitsValuesGrid);
      this.tabPage2.Controls.Add(this.ReadInputBitResult);
      this.tabPage2.Controls.Add(this.inputBitsValue);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.inputbitsIndex);
      this.tabPage2.Controls.Add(this.readInputBit);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(438, 312);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Input bits";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // pictureBox5
      // 
      this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.pictureBox5.Location = new System.Drawing.Point(13, 71);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(412, 1);
      this.pictureBox5.TabIndex = 51;
      this.pictureBox5.TabStop = false;
      // 
      // inputBitsScanProgess
      // 
      this.inputBitsScanProgess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.inputBitsScanProgess.Location = new System.Drawing.Point(150, 287);
      this.inputBitsScanProgess.Name = "inputBitsScanProgess";
      this.inputBitsScanProgess.Size = new System.Drawing.Size(199, 20);
      this.inputBitsScanProgess.TabIndex = 50;
      this.inputBitsScanProgess.Visible = false;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(6, 81);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(347, 13);
      this.label13.TabIndex = 49;
      this.label13.Text = "You can also scan all imput bits for values, although this will take a while";
      // 
      // StartInputBitsScan_btn
      // 
      this.StartInputBitsScan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.StartInputBitsScan_btn.Location = new System.Drawing.Point(357, 287);
      this.StartInputBitsScan_btn.Name = "StartInputBitsScan_btn";
      this.StartInputBitsScan_btn.Size = new System.Drawing.Size(75, 20);
      this.StartInputBitsScan_btn.TabIndex = 48;
      this.StartInputBitsScan_btn.Text = "Start";
      this.StartInputBitsScan_btn.UseVisualStyleBackColor = true;
      this.StartInputBitsScan_btn.Click += new System.EventHandler(this.StartInputBitsScan_btn_Click);
      // 
      // InputBitsScanMessage
      // 
      this.InputBitsScanMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.InputBitsScanMessage.AutoSize = true;
      this.InputBitsScanMessage.Location = new System.Drawing.Point(10, 291);
      this.InputBitsScanMessage.Name = "InputBitsScanMessage";
      this.InputBitsScanMessage.Size = new System.Drawing.Size(243, 13);
      this.InputBitsScanMessage.TabIndex = 47;
      this.InputBitsScanMessage.Text = "Click on Start to start scanning all input bits values";
      // 
      // InputBitsValuesGrid
      // 
      this.InputBitsValuesGrid.AllowUserToAddRows = false;
      this.InputBitsValuesGrid.AllowUserToDeleteRows = false;
      this.InputBitsValuesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InputBitsValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.InputBitsValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
      this.InputBitsValuesGrid.Location = new System.Drawing.Point(7, 97);
      this.InputBitsValuesGrid.Name = "InputBitsValuesGrid";
      this.InputBitsValuesGrid.ReadOnly = true;
      this.InputBitsValuesGrid.RowHeadersVisible = false;
      this.InputBitsValuesGrid.Size = new System.Drawing.Size(425, 184);
      this.InputBitsValuesGrid.TabIndex = 46;
      // 
      // dataGridViewTextBoxColumn5
      // 
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
      this.dataGridViewTextBoxColumn5.HeaderText = "Index";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn6
      // 
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
      this.dataGridViewTextBoxColumn6.HeaderText = "Value";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn7
      // 
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
      this.dataGridViewTextBoxColumn7.HeaderText = "Index (hex)";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn8
      // 
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
      this.dataGridViewTextBoxColumn8.HeaderText = "Value (hex)";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      // 
      // ReadInputBitResult
      // 
      this.ReadInputBitResult.AutoSize = true;
      this.ReadInputBitResult.Location = new System.Drawing.Point(6, 48);
      this.ReadInputBitResult.Name = "ReadInputBitResult";
      this.ReadInputBitResult.Size = new System.Drawing.Size(306, 13);
      this.ReadInputBitResult.TabIndex = 25;
      this.ReadInputBitResult.Text = "Enter an input bit number (0..9999) and click on the read button";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.pictureBox6);
      this.tabPage3.Controls.Add(this.InputRegistersScanProgess);
      this.tabPage3.Controls.Add(this.label14);
      this.tabPage3.Controls.Add(this.StartInputRegistersScan_btn);
      this.tabPage3.Controls.Add(this.InputRegistersScanMessage);
      this.tabPage3.Controls.Add(this.InputRegistersValuesGrid);
      this.tabPage3.Controls.Add(this.ReadInputRegisterResult);
      this.tabPage3.Controls.Add(this.inputRegistersValues);
      this.tabPage3.Controls.Add(this.label8);
      this.tabPage3.Controls.Add(this.InputRegistersIndex);
      this.tabPage3.Controls.Add(this.readInputRegisters_btn);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(438, 312);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Input registers";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // pictureBox6
      // 
      this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.pictureBox6.Location = new System.Drawing.Point(13, 72);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new System.Drawing.Size(412, 1);
      this.pictureBox6.TabIndex = 57;
      this.pictureBox6.TabStop = false;
      // 
      // InputRegistersScanProgess
      // 
      this.InputRegistersScanProgess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InputRegistersScanProgess.Location = new System.Drawing.Point(150, 283);
      this.InputRegistersScanProgess.Name = "InputRegistersScanProgess";
      this.InputRegistersScanProgess.Size = new System.Drawing.Size(199, 20);
      this.InputRegistersScanProgess.TabIndex = 56;
      this.InputRegistersScanProgess.Visible = false;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(6, 82);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(368, 13);
      this.label14.TabIndex = 55;
      this.label14.Text = "You can also scan all input registers for values, although this will take a while" +
    "";
      // 
      // StartInputRegistersScan_btn
      // 
      this.StartInputRegistersScan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.StartInputRegistersScan_btn.Location = new System.Drawing.Point(357, 283);
      this.StartInputRegistersScan_btn.Name = "StartInputRegistersScan_btn";
      this.StartInputRegistersScan_btn.Size = new System.Drawing.Size(75, 20);
      this.StartInputRegistersScan_btn.TabIndex = 54;
      this.StartInputRegistersScan_btn.Text = "Start";
      this.StartInputRegistersScan_btn.UseVisualStyleBackColor = true;
      this.StartInputRegistersScan_btn.Click += new System.EventHandler(this.StartInputRegistersScan_btn_Click);
      // 
      // InputRegistersScanMessage
      // 
      this.InputRegistersScanMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.InputRegistersScanMessage.AutoSize = true;
      this.InputRegistersScanMessage.Location = new System.Drawing.Point(10, 287);
      this.InputRegistersScanMessage.Name = "InputRegistersScanMessage";
      this.InputRegistersScanMessage.Size = new System.Drawing.Size(266, 13);
      this.InputRegistersScanMessage.TabIndex = 53;
      this.InputRegistersScanMessage.Text = "Click on Start to start scanning all input registers values";
      // 
      // InputRegistersValuesGrid
      // 
      this.InputRegistersValuesGrid.AllowUserToAddRows = false;
      this.InputRegistersValuesGrid.AllowUserToDeleteRows = false;
      this.InputRegistersValuesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InputRegistersValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.InputRegistersValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
      this.InputRegistersValuesGrid.Location = new System.Drawing.Point(7, 98);
      this.InputRegistersValuesGrid.Name = "InputRegistersValuesGrid";
      this.InputRegistersValuesGrid.ReadOnly = true;
      this.InputRegistersValuesGrid.RowHeadersVisible = false;
      this.InputRegistersValuesGrid.Size = new System.Drawing.Size(425, 179);
      this.InputRegistersValuesGrid.TabIndex = 52;
      // 
      // dataGridViewTextBoxColumn9
      // 
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle9;
      this.dataGridViewTextBoxColumn9.HeaderText = "Index";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn10
      // 
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle10;
      this.dataGridViewTextBoxColumn10.HeaderText = "Value";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn11
      // 
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle11;
      this.dataGridViewTextBoxColumn11.HeaderText = "Index (hex)";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn12
      // 
      dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle12;
      this.dataGridViewTextBoxColumn12.HeaderText = "Value (hex)";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      // 
      // ReadInputRegisterResult
      // 
      this.ReadInputRegisterResult.AutoSize = true;
      this.ReadInputRegisterResult.Location = new System.Drawing.Point(10, 53);
      this.ReadInputRegisterResult.Name = "ReadInputRegisterResult";
      this.ReadInputRegisterResult.Size = new System.Drawing.Size(329, 13);
      this.ReadInputRegisterResult.TabIndex = 29;
      this.ReadInputRegisterResult.Text = "Enter an input register number (0..9999) and click on the read button";
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.label23);
      this.tabPage4.Controls.Add(this.HoldingRegistersScanFrom);
      this.tabPage4.Controls.Add(this.HoldingRegistersScanProgess);
      this.tabPage4.Controls.Add(this.label12);
      this.tabPage4.Controls.Add(this.StartHoldingRegistersScan_btn);
      this.tabPage4.Controls.Add(this.HoldingRegistersMessage);
      this.tabPage4.Controls.Add(this.HoldingRegistersValuesGrid);
      this.tabPage4.Controls.Add(this.pictureBox3);
      this.tabPage4.Controls.Add(this.HoldingRegistersOperationResult);
      this.tabPage4.Controls.Add(this.HoldingRegistersWriteValue);
      this.tabPage4.Controls.Add(this.label10);
      this.tabPage4.Controls.Add(this.label9);
      this.tabPage4.Controls.Add(this.writeHoldingRegisters_btn);
      this.tabPage4.Controls.Add(this.HoldingRegistersIndex);
      this.tabPage4.Controls.Add(this.readHoldingRegisters_btn);
      this.tabPage4.Controls.Add(this.HoldingRegistersReadValue);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(438, 312);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Holding registers";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // label23
      // 
      this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(354, 281);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(30, 13);
      this.label23.TabIndex = 52;
      this.label23.Text = "from:";
      // 
      // HoldingRegistersScanFrom
      // 
      this.HoldingRegistersScanFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersScanFrom.Location = new System.Drawing.Point(385, 278);
      this.HoldingRegistersScanFrom.Name = "HoldingRegistersScanFrom";
      this.HoldingRegistersScanFrom.Size = new System.Drawing.Size(46, 20);
      this.HoldingRegistersScanFrom.TabIndex = 51;
      this.HoldingRegistersScanFrom.Text = "0";
      this.HoldingRegistersScanFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // HoldingRegistersScanProgess
      // 
      this.HoldingRegistersScanProgess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersScanProgess.Location = new System.Drawing.Point(230, 277);
      this.HoldingRegistersScanProgess.Name = "HoldingRegistersScanProgess";
      this.HoldingRegistersScanProgess.Size = new System.Drawing.Size(59, 20);
      this.HoldingRegistersScanProgess.TabIndex = 50;
      this.HoldingRegistersScanProgess.Visible = false;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(6, 121);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(379, 13);
      this.label12.TabIndex = 49;
      this.label12.Text = "You can also scan all holding registers for values, although this will take a whi" +
    "le";
      // 
      // StartHoldingRegistersScan_btn
      // 
      this.StartHoldingRegistersScan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.StartHoldingRegistersScan_btn.Location = new System.Drawing.Point(295, 277);
      this.StartHoldingRegistersScan_btn.Name = "StartHoldingRegistersScan_btn";
      this.StartHoldingRegistersScan_btn.Size = new System.Drawing.Size(53, 20);
      this.StartHoldingRegistersScan_btn.TabIndex = 48;
      this.StartHoldingRegistersScan_btn.Text = "Start";
      this.StartHoldingRegistersScan_btn.UseVisualStyleBackColor = true;
      this.StartHoldingRegistersScan_btn.Click += new System.EventHandler(this.StartHoldingRegistersScan_btn_Click);
      // 
      // HoldingRegistersMessage
      // 
      this.HoldingRegistersMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.HoldingRegistersMessage.AutoSize = true;
      this.HoldingRegistersMessage.Location = new System.Drawing.Point(3, 281);
      this.HoldingRegistersMessage.Name = "HoldingRegistersMessage";
      this.HoldingRegistersMessage.Size = new System.Drawing.Size(221, 13);
      this.HoldingRegistersMessage.TabIndex = 47;
      this.HoldingRegistersMessage.Text = "Click on Start to scan holding registers values";
      // 
      // HoldingRegistersValuesGrid
      // 
      this.HoldingRegistersValuesGrid.AllowUserToAddRows = false;
      this.HoldingRegistersValuesGrid.AllowUserToDeleteRows = false;
      this.HoldingRegistersValuesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HoldingRegistersValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.HoldingRegistersValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.HoldingRegistersValuesGrid.Location = new System.Drawing.Point(6, 139);
      this.HoldingRegistersValuesGrid.Name = "HoldingRegistersValuesGrid";
      this.HoldingRegistersValuesGrid.ReadOnly = true;
      this.HoldingRegistersValuesGrid.RowHeadersVisible = false;
      this.HoldingRegistersValuesGrid.Size = new System.Drawing.Size(425, 132);
      this.HoldingRegistersValuesGrid.TabIndex = 46;
      // 
      // dataGridViewTextBoxColumn1
      // 
      dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
      this.dataGridViewTextBoxColumn1.HeaderText = "Index";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
      this.dataGridViewTextBoxColumn2.HeaderText = "Value";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
      this.dataGridViewTextBoxColumn3.HeaderText = "Index (hex)";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
      this.dataGridViewTextBoxColumn4.HeaderText = "Value (hex)";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.pictureBox3.Location = new System.Drawing.Point(11, 117);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(421, 1);
      this.pictureBox3.TabIndex = 37;
      this.pictureBox3.TabStop = false;
      // 
      // HoldingRegistersOperationResult
      // 
      this.HoldingRegistersOperationResult.AutoSize = true;
      this.HoldingRegistersOperationResult.Location = new System.Drawing.Point(3, 79);
      this.HoldingRegistersOperationResult.Name = "HoldingRegistersOperationResult";
      this.HoldingRegistersOperationResult.Size = new System.Drawing.Size(428, 26);
      this.HoldingRegistersOperationResult.TabIndex = 36;
      this.HoldingRegistersOperationResult.Text = "Enter an input register number (0..9999)  a value (0..65535) and click on the rea" +
    "d or write \r\nbutton";
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.cpyToClipBoard_btn);
      this.tabPage6.Controls.Add(this.ClearSnoopingLogs_btn);
      this.tabPage6.Controls.Add(this.SnoopingContents);
      this.tabPage6.Controls.Add(this.label24);
      this.tabPage6.Location = new System.Drawing.Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new System.Drawing.Size(438, 312);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "Snooping";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // cpyToClipBoard_btn
      // 
      this.cpyToClipBoard_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cpyToClipBoard_btn.Location = new System.Drawing.Point(240, 289);
      this.cpyToClipBoard_btn.Name = "cpyToClipBoard_btn";
      this.cpyToClipBoard_btn.Size = new System.Drawing.Size(129, 20);
      this.cpyToClipBoard_btn.TabIndex = 50;
      this.cpyToClipBoard_btn.Text = "Copy to clipboard";
      this.cpyToClipBoard_btn.UseVisualStyleBackColor = true;
      this.cpyToClipBoard_btn.Click += new System.EventHandler(this.cpyToClipBoard_btn_Click);
      // 
      // ClearSnoopingLogs_btn
      // 
      this.ClearSnoopingLogs_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ClearSnoopingLogs_btn.Location = new System.Drawing.Point(378, 289);
      this.ClearSnoopingLogs_btn.Name = "ClearSnoopingLogs_btn";
      this.ClearSnoopingLogs_btn.Size = new System.Drawing.Size(53, 20);
      this.ClearSnoopingLogs_btn.TabIndex = 49;
      this.ClearSnoopingLogs_btn.Text = "Clear";
      this.ClearSnoopingLogs_btn.UseVisualStyleBackColor = true;
      this.ClearSnoopingLogs_btn.Click += new System.EventHandler(this.ClearSnoopingLogs_btn_Click);
      // 
      // SnoopingContents
      // 
      this.SnoopingContents.AllowUserToAddRows = false;
      this.SnoopingContents.AllowUserToDeleteRows = false;
      this.SnoopingContents.AllowUserToResizeRows = false;
      this.SnoopingContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SnoopingContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SnoopingContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Addr,
            this.Column4});
      this.SnoopingContents.Location = new System.Drawing.Point(6, 35);
      this.SnoopingContents.Name = "SnoopingContents";
      this.SnoopingContents.RowHeadersVisible = false;
      this.SnoopingContents.Size = new System.Drawing.Size(425, 246);
      this.SnoopingContents.TabIndex = 45;
      this.SnoopingContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // label24
      // 
      this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label24.Location = new System.Drawing.Point(3, 13);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(432, 29);
      this.label24.TabIndex = 44;
      this.label24.Text = "Here are all the data transiting on the data lines.\r\n";
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.textlogs);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(438, 312);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Logs";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // label15
      // 
      this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label15.BackColor = System.Drawing.Color.DodgerBlue;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.ForeColor = System.Drawing.Color.White;
      this.label15.Location = new System.Drawing.Point(5, 5);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(451, 21);
      this.label15.TabIndex = 37;
      this.label15.Text = "1 - Choose Modbus interface";
      // 
      // label16
      // 
      this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label16.BackColor = System.Drawing.Color.DodgerBlue;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.ForeColor = System.Drawing.Color.White;
      this.label16.Location = new System.Drawing.Point(5, 153);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(451, 21);
      this.label16.TabIndex = 38;
      this.label16.Text = "2 - Find out Modbus slave address";
      // 
      // label17
      // 
      this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label17.BackColor = System.Drawing.Color.DodgerBlue;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.ForeColor = System.Drawing.Color.White;
      this.label17.Location = new System.Drawing.Point(5, 288);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(451, 21);
      this.label17.TabIndex = 39;
      this.label17.Text = "3 - Inspect / modify Modbus data";
      // 
      // label18
      // 
      this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label18.Location = new System.Drawing.Point(12, 33);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(444, 29);
      this.label18.TabIndex = 40;
      this.label18.Text = "Choose the yoctopuce device used for modbus communication. This device must featu" +
    "re a serialport feature with a preselected modbus protocol.";
      // 
      // label19
      // 
      this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label19.Location = new System.Drawing.Point(10, 177);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(444, 29);
      this.label19.TabIndex = 41;
      this.label19.Text = "Then you need to enter the Slave\'s modbus address. You will find it in the slave " +
    "device documentation. If don\'t have the documentation, you can try to scan the b" +
    "us.";
      // 
      // label20
      // 
      this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label20.Location = new System.Drawing.Point(10, 314);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(444, 29);
      this.label20.TabIndex = 42;
      this.label20.Text = "You can read / write slave\'s coils, inputs bits, input registers and holding regi" +
    "sters. Note that inputs bits and input registers are read-only.";
      // 
      // label21
      // 
      this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label21.AutoSize = true;
      this.label21.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.ForeColor = System.Drawing.Color.RoyalBlue;
      this.label21.Location = new System.Drawing.Point(260, 685);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(195, 13);
      this.label21.TabIndex = 43;
      this.label21.Text = "More info about modbus (external link)...";
      this.label21.Click += new System.EventHandler(this.label21_Click);
      // 
      // scanlabel
      // 
      this.scanlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scanlabel.Location = new System.Drawing.Point(11, 234);
      this.scanlabel.Name = "scanlabel";
      this.scanlabel.Size = new System.Drawing.Size(439, 23);
      this.scanlabel.TabIndex = 11;
      this.scanlabel.Text = "If you don\'t know your modbus device addess, click on the scan button above.";
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Timestamp";
      this.Column1.Name = "Column1";
      this.Column1.Width = 70;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Dir.";
      this.Column2.Name = "Column2";
      this.Column2.Width = 30;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Raw Message";
      this.Column3.Name = "Column3";
      this.Column3.Width = 190;
      // 
      // Addr
      // 
      this.Addr.HeaderText = "Addr";
      this.Addr.Name = "Addr";
      this.Addr.Width = 75;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Decoded Contents";
      this.Column4.Name = "Column4";
      this.Column4.Width = 400;
      // 
      // BuildNumber_label
      // 
      this.BuildNumber_label.AutoSize = true;
      this.BuildNumber_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
      this.BuildNumber_label.Location = new System.Drawing.Point(13, 685);
      this.BuildNumber_label.Name = "BuildNumber_label";
      this.BuildNumber_label.Size = new System.Drawing.Size(0, 13);
      this.BuildNumber_label.TabIndex = 44;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 707);
      this.Controls.Add(this.BuildNumber_label);
      this.Controls.Add(this.label21);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.label19);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.writeCoil_btn);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.slaveAddr);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.scanlabel);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Parity);
      this.Controls.Add(this.Speed);
      this.Controls.Add(this.Protocol);
      this.Controls.Add(this.interfaceChooser);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Yoctopuce ModBus Tool";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.writeCoil_btn.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CoilValuesGrid)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.InputBitsValuesGrid)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.InputRegistersValuesGrid)).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.HoldingRegistersValuesGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.tabPage6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SnoopingContents)).EndInit();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox interfaceChooser;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ComboBox Protocol;
    private System.Windows.Forms.ComboBox Speed;
    private System.Windows.Forms.ComboBox Parity;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textlogs;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.TextBox slaveAddr;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox CoilNumber;
    private System.Windows.Forms.Button readCoil_btn;
    private System.Windows.Forms.TextBox coilValue;
    private System.Windows.Forms.TextBox inputBitsValue;
    private System.Windows.Forms.Button readInputBit;
    private System.Windows.Forms.TextBox inputbitsIndex;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox inputRegistersValues;
    private System.Windows.Forms.Button readInputRegisters_btn;
    private System.Windows.Forms.TextBox InputRegistersIndex;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox HoldingRegistersReadValue;
    private System.Windows.Forms.Button readHoldingRegisters_btn;
    private System.Windows.Forms.TextBox HoldingRegistersIndex;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox HoldingRegistersWriteValue;
    private System.Windows.Forms.Button writeHoldingRegisters_btn;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TabControl writeCoil_btn;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.Label ReadCoilResult;
    private System.Windows.Forms.Label ReadInputBitResult;
    private System.Windows.Forms.Label ReadInputRegisterResult;
    private System.Windows.Forms.Label HoldingRegistersOperationResult;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.Button StartCoilsScan_btn;
    private System.Windows.Forms.DataGridView CoilValuesGrid;
    private System.Windows.Forms.ProgressBar coilScanProgess;
    private System.Windows.Forms.Label coilScanMessage;
    private System.Windows.Forms.ProgressBar HoldingRegistersScanProgess;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button StartHoldingRegistersScan_btn;
    private System.Windows.Forms.Label HoldingRegistersMessage;
    private System.Windows.Forms.DataGridView HoldingRegistersValuesGrid;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.ProgressBar inputBitsScanProgess;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button StartInputBitsScan_btn;
    private System.Windows.Forms.Label InputBitsScanMessage;
    private System.Windows.Forms.DataGridView InputBitsValuesGrid;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.ProgressBar InputRegistersScanProgess;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Button StartInputRegistersScan_btn;
    private System.Windows.Forms.Label InputRegistersScanMessage;
    private System.Windows.Forms.DataGridView InputRegistersValuesGrid;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label scanlabel;
    private System.Windows.Forms.TextBox coilWriteValue;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Button writeCoil2_btn;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.TextBox HoldingRegistersScanFrom;
    private System.Windows.Forms.DataGridViewTextBoxColumn Index;
    private System.Windows.Forms.DataGridViewTextBoxColumn indexHex;
    private System.Windows.Forms.DataGridViewTextBoxColumn col3;
    private System.Windows.Forms.DataGridViewTextBoxColumn valueHex;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.DataGridView SnoopingContents;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Button ClearSnoopingLogs_btn;
    private System.Windows.Forms.Button cpyToClipBoard_btn;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Addr;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.Label BuildNumber_label;
  }
}

