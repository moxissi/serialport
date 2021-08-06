
namespace comporttest
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_LogStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SendData = new System.Windows.Forms.TextBox();
            this.btn_SendData = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tc_Settings = new System.Windows.Forms.TabControl();
            this.tp_PortSettings = new System.Windows.Forms.TabPage();
            this.tp_LogSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_EnableLog = new System.Windows.Forms.CheckBox();
            this.tb_LogFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tc_Settings.SuspendLayout();
            this.tp_PortSettings.SuspendLayout();
            this.tp_LogSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(306, 41);
            this.tb_Data.Multiline = true;
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.ReadOnly = true;
            this.tb_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Data.Size = new System.Drawing.Size(642, 272);
            this.tb_Data.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(60, 118);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(128, 35);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ts_LogStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 25);
            this.toolStripStatusLabel1.Text = "Disconnected";
            // 
            // ts_LogStatus
            // 
            this.ts_LogStatus.Name = "ts_LogStatus";
            this.ts_LogStatus.Size = new System.Drawing.Size(114, 25);
            this.ts_LogStatus.Text = "Log disabled";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Connect.Location = new System.Drawing.Point(78, 204);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(128, 40);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cb_Ports
            // 
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(105, 27);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(115, 28);
            this.cb_Ports.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Ports);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM serial port settings";
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_BaudRate.Location = new System.Drawing.Point(105, 65);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(115, 28);
            this.cb_BaudRate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // tb_SendData
            // 
            this.tb_SendData.Location = new System.Drawing.Point(398, 329);
            this.tb_SendData.Name = "tb_SendData";
            this.tb_SendData.Size = new System.Drawing.Size(550, 26);
            this.tb_SendData.TabIndex = 11;
            // 
            // btn_SendData
            // 
            this.btn_SendData.Location = new System.Drawing.Point(398, 372);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(128, 40);
            this.btn_SendData.TabIndex = 12;
            this.btn_SendData.Text = "Send";
            this.btn_SendData.UseVisualStyleBackColor = true;
            this.btn_SendData.Click += new System.EventHandler(this.btn_SendData_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(820, 372);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 40);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Send Data:";
            // 
            // tc_Settings
            // 
            this.tc_Settings.Controls.Add(this.tp_PortSettings);
            this.tc_Settings.Controls.Add(this.tp_LogSettings);
            this.tc_Settings.Location = new System.Drawing.Point(5, 12);
            this.tc_Settings.Name = "tc_Settings";
            this.tc_Settings.SelectedIndex = 0;
            this.tc_Settings.Size = new System.Drawing.Size(295, 301);
            this.tc_Settings.TabIndex = 15;
            // 
            // tp_PortSettings
            // 
            this.tp_PortSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tp_PortSettings.Controls.Add(this.groupBox1);
            this.tp_PortSettings.Controls.Add(this.btn_Connect);
            this.tp_PortSettings.Location = new System.Drawing.Point(4, 29);
            this.tp_PortSettings.Name = "tp_PortSettings";
            this.tp_PortSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PortSettings.Size = new System.Drawing.Size(287, 268);
            this.tp_PortSettings.TabIndex = 0;
            this.tp_PortSettings.Text = "Port settings";
            // 
            // tp_LogSettings
            // 
            this.tp_LogSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tp_LogSettings.Controls.Add(this.groupBox2);
            this.tp_LogSettings.Location = new System.Drawing.Point(4, 29);
            this.tp_LogSettings.Name = "tp_LogSettings";
            this.tp_LogSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_LogSettings.Size = new System.Drawing.Size(287, 268);
            this.tp_LogSettings.TabIndex = 1;
            this.tp_LogSettings.Text = "Log settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_EnableLog);
            this.groupBox2.Controls.Add(this.tb_LogFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_SelectFile);
            this.groupBox2.Location = new System.Drawing.Point(17, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 228);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log file settings";
            // 
            // cb_EnableLog
            // 
            this.cb_EnableLog.AutoSize = true;
            this.cb_EnableLog.Location = new System.Drawing.Point(12, 170);
            this.cb_EnableLog.Name = "cb_EnableLog";
            this.cb_EnableLog.Size = new System.Drawing.Size(110, 24);
            this.cb_EnableLog.TabIndex = 19;
            this.cb_EnableLog.Text = "Enable log";
            this.cb_EnableLog.UseVisualStyleBackColor = true;
            this.cb_EnableLog.Click += new System.EventHandler(this.cb_EnableLog_Click);
            // 
            // tb_LogFilePath
            // 
            this.tb_LogFilePath.Location = new System.Drawing.Point(60, 44);
            this.tb_LogFilePath.Name = "tb_LogFilePath";
            this.tb_LogFilePath.Size = new System.Drawing.Size(178, 26);
            this.tb_LogFilePath.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Path:";
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(85, 86);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(128, 40);
            this.btn_SelectFile.TabIndex = 16;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 472);
            this.Controls.Add(this.tc_Settings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_SendData);
            this.Controls.Add(this.tb_SendData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial Port";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tc_Settings.ResumeLayout(false);
            this.tp_PortSettings.ResumeLayout(false);
            this.tp_LogSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Data;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.TextBox tb_SendData;
        private System.Windows.Forms.Button btn_SendData;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tc_Settings;
        private System.Windows.Forms.TabPage tp_PortSettings;
        private System.Windows.Forms.TabPage tp_LogSettings;
        private System.Windows.Forms.TextBox tb_LogFilePath;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_EnableLog;
        private System.Windows.Forms.ToolStripStatusLabel ts_LogStatus;
    }
}

