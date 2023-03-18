
namespace SoapUI
{
    partial class MainUI
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
            this.baseUrlLbl = new System.Windows.Forms.Label();
            this.baseUrl = new System.Windows.Forms.TextBox();
            this.ipLbl = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.executeBtn = new System.Windows.Forms.Button();
            this.soapAction = new System.Windows.Forms.ComboBox();
            this.soapLbl = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.noExtraInfoLbl = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openJobPanel = new System.Windows.Forms.Panel();
            this.jobIdLbl = new System.Windows.Forms.Label();
            this.openJobId = new System.Windows.Forms.TextBox();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.openJobPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseUrlLbl
            // 
            this.baseUrlLbl.AutoSize = true;
            this.baseUrlLbl.Location = new System.Drawing.Point(10, 11);
            this.baseUrlLbl.Name = "baseUrlLbl";
            this.baseUrlLbl.Size = new System.Drawing.Size(59, 13);
            this.baseUrlLbl.TabIndex = 0;
            this.baseUrlLbl.Text = "Base URL:";
            // 
            // baseUrl
            // 
            this.baseUrl.Location = new System.Drawing.Point(13, 27);
            this.baseUrl.Name = "baseUrl";
            this.baseUrl.Size = new System.Drawing.Size(134, 20);
            this.baseUrl.TabIndex = 1;
            this.baseUrl.Text = "roblox.com";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(10, 50);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(20, 13);
            this.ipLbl.TabIndex = 2;
            this.ipLbl.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(13, 67);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(134, 20);
            this.ip.TabIndex = 3;
            this.ip.Text = "127.0.0.1";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(10, 90);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(29, 13);
            this.portLbl.TabIndex = 4;
            this.portLbl.Text = "Port:";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(13, 106);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(134, 20);
            this.port.TabIndex = 5;
            this.port.Text = "64989";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.executeBtn);
            this.settingsPanel.Controls.Add(this.soapAction);
            this.settingsPanel.Controls.Add(this.soapLbl);
            this.settingsPanel.Controls.Add(this.ip);
            this.settingsPanel.Controls.Add(this.port);
            this.settingsPanel.Controls.Add(this.portLbl);
            this.settingsPanel.Controls.Add(this.ipLbl);
            this.settingsPanel.Controls.Add(this.baseUrl);
            this.settingsPanel.Controls.Add(this.baseUrlLbl);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(282, 312);
            this.settingsPanel.TabIndex = 6;
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(13, 172);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(255, 23);
            this.executeBtn.TabIndex = 8;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // soapAction
            // 
            this.soapAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soapAction.FormattingEnabled = true;
            this.soapAction.Items.AddRange(new object[] {
            "HelloWorld",
            "GetVersion",
            "GetStatus",
            "OpenJobEx",
            "RenewLease",
            "ExecuteEx",
            "Execute",
            "CloseJob",
            "DiagEx",
            "GetAllJobsEx",
            "CloseExpiredJobs",
            "CloseAllJobs",
            "BatchJobEx"});
            this.soapAction.Location = new System.Drawing.Point(13, 145);
            this.soapAction.Name = "soapAction";
            this.soapAction.Size = new System.Drawing.Size(134, 21);
            this.soapAction.TabIndex = 7;
            this.soapAction.SelectedValueChanged += new System.EventHandler(this.soapAction_SelectedValueChanged);
            // 
            // soapLbl
            // 
            this.soapLbl.AutoSize = true;
            this.soapLbl.Location = new System.Drawing.Point(10, 129);
            this.soapLbl.Name = "soapLbl";
            this.soapLbl.Size = new System.Drawing.Size(72, 13);
            this.soapLbl.TabIndex = 6;
            this.soapLbl.Text = "SOAP Action:";
            // 
            // actionPanel
            // 
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionPanel.Controls.Add(this.openJobPanel);
            this.actionPanel.Controls.Add(this.noExtraInfoLbl);
            this.actionPanel.Location = new System.Drawing.Point(301, 12);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(487, 312);
            this.actionPanel.TabIndex = 7;
            // 
            // noExtraInfoLbl
            // 
            this.noExtraInfoLbl.AutoSize = true;
            this.noExtraInfoLbl.Location = new System.Drawing.Point(139, 153);
            this.noExtraInfoLbl.Name = "noExtraInfoLbl";
            this.noExtraInfoLbl.Size = new System.Drawing.Size(225, 13);
            this.noExtraInfoLbl.TabIndex = 0;
            this.noExtraInfoLbl.Text = "No extra information is needed for this request.";
            this.noExtraInfoLbl.Visible = false;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.Control;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Location = new System.Drawing.Point(12, 331);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(776, 85);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Created by pos0#0998. March 17 2023 build. https://github.com/p0s0/SoapUI";
            // 
            // openJobPanel
            // 
            this.openJobPanel.Controls.Add(this.randomizeButton);
            this.openJobPanel.Controls.Add(this.openJobId);
            this.openJobPanel.Controls.Add(this.jobIdLbl);
            this.openJobPanel.Location = new System.Drawing.Point(3, 3);
            this.openJobPanel.Name = "openJobPanel";
            this.openJobPanel.Size = new System.Drawing.Size(479, 304);
            this.openJobPanel.TabIndex = 1;
            this.openJobPanel.Visible = false;
            // 
            // jobIdLbl
            // 
            this.jobIdLbl.AutoSize = true;
            this.jobIdLbl.Location = new System.Drawing.Point(13, 12);
            this.jobIdLbl.Name = "jobIdLbl";
            this.jobIdLbl.Size = new System.Drawing.Size(41, 13);
            this.jobIdLbl.TabIndex = 0;
            this.jobIdLbl.Text = "Job ID:";
            // 
            // openJobId
            // 
            this.openJobId.Location = new System.Drawing.Point(16, 28);
            this.openJobId.Name = "openJobId";
            this.openJobId.Size = new System.Drawing.Size(155, 20);
            this.openJobId.TabIndex = 1;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(177, 28);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(79, 20);
            this.randomizeButton.TabIndex = 2;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainUI";
            this.Text = "SoapUI";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.openJobPanel.ResumeLayout(false);
            this.openJobPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseUrlLbl;
        private System.Windows.Forms.TextBox baseUrl;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.ComboBox soapAction;
        private System.Windows.Forms.Label soapLbl;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Label noExtraInfoLbl;
        public System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel openJobPanel;
        private System.Windows.Forms.Label jobIdLbl;
        private System.Windows.Forms.TextBox openJobId;
        private System.Windows.Forms.Button randomizeButton;
    }
}

