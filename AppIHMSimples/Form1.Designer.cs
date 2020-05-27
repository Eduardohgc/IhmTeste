﻿namespace AppIHMSimples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbEnviar = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtRecep = new System.Windows.Forms.TextBox();
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.pnlLed1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLed2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlLed1.SuspendLayout();
            this.pnlLed2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(4, 4);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(73, 17);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "COM Port:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(83, 4);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(163, 24);
            this.cbBoxPort.TabIndex = 1;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(4, 50);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(79, 17);
            this.lblBaud.TabIndex = 2;
            this.lblBaud.Text = "Baud Rate:";
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(83, 50);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(163, 24);
            this.cbBoxBaud.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(4, 100);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 17);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data Bits:";
            // 
            // cbBoxData
            // 
            this.cbBoxData.FormattingEnabled = true;
            this.cbBoxData.Location = new System.Drawing.Point(83, 100);
            this.cbBoxData.Name = "cbBoxData";
            this.cbBoxData.Size = new System.Drawing.Size(163, 24);
            this.cbBoxData.TabIndex = 5;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(4, 150);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(68, 17);
            this.lblStop.TabIndex = 6;
            this.lblStop.Text = "Stop Bits:";
            // 
            // cbBoxStop
            // 
            this.cbBoxStop.FormattingEnabled = true;
            this.cbBoxStop.Location = new System.Drawing.Point(83, 150);
            this.cbBoxStop.Name = "cbBoxStop";
            this.cbBoxStop.Size = new System.Drawing.Size(163, 24);
            this.cbBoxStop.TabIndex = 7;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(4, 200);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 17);
            this.lblParity.TabIndex = 8;
            this.lblParity.Text = "Parity:";
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(83, 200);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(163, 24);
            this.cbBoxParity.TabIndex = 9;
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(7, 255);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(117, 33);
            this.btnCom.TabIndex = 10;
            this.btnCom.Text = "Open Port";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnDes
            // 
            this.btnDes.Enabled = false;
            this.btnDes.Location = new System.Drawing.Point(129, 255);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(117, 33);
            this.btnDes.TabIndex = 11;
            this.btnDes.Text = "Close Port";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnFec
            // 
            this.btnFec.Location = new System.Drawing.Point(7, 309);
            this.btnFec.Name = "btnFec";
            this.btnFec.Size = new System.Drawing.Size(239, 33);
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
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(250, 562);
            this.pnl1.TabIndex = 0;
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.Color.Red;
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMsg.Controls.Add(this.label1);
            this.pnlMsg.Location = new System.Drawing.Point(7, 357);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(239, 191);
            this.pnlMsg.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(268, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 562);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.chbEnviar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtEnviar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmissão";
            // 
            // chbEnviar
            // 
            this.chbEnviar.AutoSize = true;
            this.chbEnviar.Location = new System.Drawing.Point(7, 64);
            this.chbEnviar.Name = "chbEnviar";
            this.chbEnviar.Size = new System.Drawing.Size(49, 21);
            this.chbEnviar.TabIndex = 2;
            this.chbEnviar.Text = "CR";
            this.chbEnviar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(372, 15);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 30);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(6, 21);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(360, 22);
            this.txtEnviar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlLed2);
            this.tabPage2.Controls.Add(this.btnBotao2);
            this.tabPage2.Controls.Add(this.pnlLed1);
            this.tabPage2.Controls.Add(this.btnBotao1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Botões/Leds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(492, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Controls.Add(this.txtRecep);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepção";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(365, 13);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(100, 30);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtRecep
            // 
            this.txtRecep.Location = new System.Drawing.Point(6, 49);
            this.txtRecep.Multiline = true;
            this.txtRecep.Name = "txtRecep";
            this.txtRecep.Size = new System.Drawing.Size(455, 356);
            this.txtRecep.TabIndex = 0;
            // 
            // btnBotao1
            // 
            this.btnBotao1.Location = new System.Drawing.Point(22, 11);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(100, 50);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Botão 1";
            this.btnBotao1.UseVisualStyleBackColor = true;
            this.btnBotao1.Click += new System.EventHandler(this.btnBotao1_Click);
            // 
            // pnlLed1
            // 
            this.pnlLed1.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed1.Controls.Add(this.label2);
            this.pnlLed1.Location = new System.Drawing.Point(22, 75);
            this.pnlLed1.Name = "pnlLed1";
            this.pnlLed1.Size = new System.Drawing.Size(100, 50);
            this.pnlLed1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Led 1";
            // 
            // pnlLed2
            // 
            this.pnlLed2.BackColor = System.Drawing.Color.Maroon;
            this.pnlLed2.Controls.Add(this.label3);
            this.pnlLed2.Location = new System.Drawing.Point(161, 75);
            this.pnlLed2.Name = "pnlLed2";
            this.pnlLed2.Size = new System.Drawing.Size(100, 50);
            this.pnlLed2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Led 2";
            // 
            // btnBotao2
            // 
            this.btnBotao2.Location = new System.Drawing.Point(161, 11);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(100, 50);
            this.btnBotao2.TabIndex = 2;
            this.btnBotao2.Text = "Botão 2";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.Text = "IHM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlLed1.ResumeLayout(false);
            this.pnlLed1.PerformLayout();
            this.pnlLed2.ResumeLayout(false);
            this.pnlLed2.PerformLayout();
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
    }
}

