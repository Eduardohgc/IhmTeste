namespace AppIHMSimples
{
    partial class Form1
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
            this.lblPort = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbBoxData = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.cbBoxStop = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnFec = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtRecep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbEnviar = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlLed2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.pnlLed1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValorSen2 = new System.Windows.Forms.Label();
            this.lblValorSen1 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pnl1.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlLed2.SuspendLayout();
            this.pnlLed1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 3);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(56, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "COM Port:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(62, 3);
            this.cbBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(123, 21);
            this.cbBoxPort.TabIndex = 1;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(3, 41);
            this.lblBaud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(61, 13);
            this.lblBaud.TabIndex = 2;
            this.lblBaud.Text = "Baud Rate:";
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(62, 41);
            this.cbBoxBaud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(123, 21);
            this.cbBoxBaud.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 81);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data Bits:";
            // 
            // cbBoxData
            // 
            this.cbBoxData.FormattingEnabled = true;
            this.cbBoxData.Location = new System.Drawing.Point(62, 81);
            this.cbBoxData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoxData.Name = "cbBoxData";
            this.cbBoxData.Size = new System.Drawing.Size(123, 21);
            this.cbBoxData.TabIndex = 5;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(3, 122);
            this.lblStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(52, 13);
            this.lblStop.TabIndex = 6;
            this.lblStop.Text = "Stop Bits:";
            // 
            // cbBoxStop
            // 
            this.cbBoxStop.FormattingEnabled = true;
            this.cbBoxStop.Location = new System.Drawing.Point(62, 122);
            this.cbBoxStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoxStop.Name = "cbBoxStop";
            this.cbBoxStop.Size = new System.Drawing.Size(123, 21);
            this.cbBoxStop.TabIndex = 7;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(3, 162);
            this.lblParity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(36, 13);
            this.lblParity.TabIndex = 8;
            this.lblParity.Text = "Parity:";
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(62, 162);
            this.cbBoxParity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(123, 21);
            this.cbBoxParity.TabIndex = 9;
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(5, 207);
            this.btnCom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(88, 27);
            this.btnCom.TabIndex = 10;
            this.btnCom.Text = "Open Port";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnDes
            // 
            this.btnDes.Enabled = false;
            this.btnDes.Location = new System.Drawing.Point(97, 207);
            this.btnDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(88, 27);
            this.btnDes.TabIndex = 11;
            this.btnDes.Text = "Close Port";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnFec
            // 
            this.btnFec.Location = new System.Drawing.Point(5, 251);
            this.btnFec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFec.Name = "btnFec";
            this.btnFec.Size = new System.Drawing.Size(179, 27);
            this.btnFec.TabIndex = 12;
            this.btnFec.Text = "Exit";
            this.btnFec.UseVisualStyleBackColor = true;
            this.btnFec.Click += new System.EventHandler(this.btnFec_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl1.Controls.Add(this.pnlMsg);
            this.pnl1.Controls.Add(this.btnFec);
            this.pnl1.Controls.Add(this.btnDes);
            this.pnl1.Controls.Add(this.btnCom);
            this.pnl1.Controls.Add(this.cbBoxParity);
            this.pnl1.Controls.Add(this.lblParity);
            this.pnl1.Controls.Add(this.cbBoxStop);
            this.pnl1.Controls.Add(this.lblStop);
            this.pnl1.Controls.Add(this.cbBoxData);
            this.pnl1.Controls.Add(this.lblData);
            this.pnl1.Controls.Add(this.cbBoxBaud);
            this.pnl1.Controls.Add(this.lblBaud);
            this.pnl1.Controls.Add(this.cbBoxPort);
            this.pnl1.Controls.Add(this.lblPort);
            this.pnl1.Location = new System.Drawing.Point(9, 10);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(188, 457);
            this.pnl1.TabIndex = 0;
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.Color.Red;
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMsg.Controls.Add(this.label1);
            this.pnlMsg.Location = new System.Drawing.Point(5, 290);
            this.pnlMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(180, 156);
            this.pnlMsg.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(201, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 457);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(367, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Controls.Add(this.txtRecep);
            this.groupBox2.Location = new System.Drawing.Point(10, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(350, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepção";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(274, 11);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 24);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtRecep
            // 
            this.txtRecep.Location = new System.Drawing.Point(4, 40);
            this.txtRecep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRecep.Multiline = true;
            this.txtRecep.Name = "txtRecep";
            this.txtRecep.Size = new System.Drawing.Size(342, 290);
            this.txtRecep.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.chbEnviar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtEnviar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmissão";
            // 
            // chbEnviar
            // 
            this.chbEnviar.AutoSize = true;
            this.chbEnviar.Location = new System.Drawing.Point(5, 52);
            this.chbEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbEnviar.Name = "chbEnviar";
            this.chbEnviar.Size = new System.Drawing.Size(41, 17);
            this.chbEnviar.TabIndex = 2;
            this.chbEnviar.Text = "CR";
            this.chbEnviar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(279, 12);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 24);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(4, 17);
            this.txtEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(271, 20);
            this.txtEnviar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.pnlLed2);
            this.tabPage2.Controls.Add(this.btnBotao2);
            this.tabPage2.Controls.Add(this.pnlLed1);
            this.tabPage2.Controls.Add(this.btnBotao1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(367, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Botões/Leds";
            // 
            // pnlLed2
            // 
            this.pnlLed2.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLed2.Controls.Add(this.label3);
            this.pnlLed2.Location = new System.Drawing.Point(121, 61);
            this.pnlLed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLed2.Name = "pnlLed2";
            this.pnlLed2.Size = new System.Drawing.Size(76, 41);
            this.pnlLed2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Led 2";
            // 
            // btnBotao2
            // 
            this.btnBotao2.Location = new System.Drawing.Point(121, 9);
            this.btnBotao2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(75, 41);
            this.btnBotao2.TabIndex = 2;
            this.btnBotao2.Text = "Botão 2";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // pnlLed1
            // 
            this.pnlLed1.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLed1.Controls.Add(this.label2);
            this.pnlLed1.Location = new System.Drawing.Point(16, 61);
            this.pnlLed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLed1.Name = "pnlLed1";
            this.pnlLed1.Size = new System.Drawing.Size(76, 41);
            this.pnlLed1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Led 1";
            // 
            // btnBotao1
            // 
            this.btnBotao1.Location = new System.Drawing.Point(16, 9);
            this.btnBotao1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(75, 41);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Botão 1";
            this.btnBotao1.UseVisualStyleBackColor = true;
            this.btnBotao1.Click += new System.EventHandler(this.btnBotao1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(367, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblValorSen2);
            this.groupBox3.Controls.Add(this.lblValorSen1);
            this.groupBox3.Controls.Add(this.lblSensor2);
            this.groupBox3.Controls.Add(this.lblSensor1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(364, 153);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblValorSen2
            // 
            this.lblValorSen2.AutoSize = true;
            this.lblValorSen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSen2.Location = new System.Drawing.Point(130, 98);
            this.lblValorSen2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorSen2.Name = "lblValorSen2";
            this.lblValorSen2.Size = new System.Drawing.Size(74, 31);
            this.lblValorSen2.TabIndex = 3;
            this.lblValorSen2.Text = "0000";
            // 
            // lblValorSen1
            // 
            this.lblValorSen1.AutoSize = true;
            this.lblValorSen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSen1.Location = new System.Drawing.Point(130, 17);
            this.lblValorSen1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorSen1.Name = "lblValorSen1";
            this.lblValorSen1.Size = new System.Drawing.Size(74, 31);
            this.lblValorSen1.TabIndex = 2;
            this.lblValorSen1.Text = "0000";
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor2.Location = new System.Drawing.Point(4, 98);
            this.lblSensor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(130, 31);
            this.lblSensor2.TabIndex = 1;
            this.lblSensor2.Text = "Sensor 2:";
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor1.Location = new System.Drawing.Point(4, 15);
            this.lblSensor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(130, 31);
            this.lblSensor1.TabIndex = 0;
            this.lblSensor1.Text = "Sensor 1:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 240);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "IHM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlLed2.ResumeLayout(false);
            this.pnlLed2.PerformLayout();
            this.pnlLed1.ResumeLayout(false);
            this.pnlLed1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbBoxData;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.ComboBox cbBoxStop;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbBoxParity;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnFec;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtRecep;
        private System.Windows.Forms.Panel pnlLed2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Panel pnlLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label lblValorSen2;
        private System.Windows.Forms.Label lblValorSen1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

