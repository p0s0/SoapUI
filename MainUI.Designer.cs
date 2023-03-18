
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
            this.openJobPanel = new System.Windows.Forms.Panel();
            this.openJobScript = new System.Windows.Forms.RichTextBox();
            this.scriptLbl = new System.Windows.Forms.Label();
            this.openJobCores = new System.Windows.Forms.TextBox();
            this.coresLbl = new System.Windows.Forms.Label();
            this.openJobCategory = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.openJobExpiration = new System.Windows.Forms.TextBox();
            this.expirationLbl = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.openJobId = new System.Windows.Forms.TextBox();
            this.jobIdLbl = new System.Windows.Forms.Label();
            this.noExtraInfoLbl = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.createdByLbl = new System.Windows.Forms.Label();
            this.renewJobPanel = new System.Windows.Forms.Panel();
            this.renewExpiration = new System.Windows.Forms.TextBox();
            this.expirationLbl2 = new System.Windows.Forms.Label();
            this.renewJobId = new System.Windows.Forms.TextBox();
            this.jobIdLbl2 = new System.Windows.Forms.Label();
            this.settingsPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.openJobPanel.SuspendLayout();
            this.renewJobPanel.SuspendLayout();
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
            this.actionPanel.Controls.Add(this.renewJobPanel);
            this.actionPanel.Controls.Add(this.openJobPanel);
            this.actionPanel.Controls.Add(this.noExtraInfoLbl);
            this.actionPanel.Location = new System.Drawing.Point(301, 12);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(487, 312);
            this.actionPanel.TabIndex = 7;
            // 
            // openJobPanel
            // 
            this.openJobPanel.Controls.Add(this.openJobScript);
            this.openJobPanel.Controls.Add(this.scriptLbl);
            this.openJobPanel.Controls.Add(this.openJobCores);
            this.openJobPanel.Controls.Add(this.coresLbl);
            this.openJobPanel.Controls.Add(this.openJobCategory);
            this.openJobPanel.Controls.Add(this.categoryLbl);
            this.openJobPanel.Controls.Add(this.openJobExpiration);
            this.openJobPanel.Controls.Add(this.expirationLbl);
            this.openJobPanel.Controls.Add(this.randomizeButton);
            this.openJobPanel.Controls.Add(this.openJobId);
            this.openJobPanel.Controls.Add(this.jobIdLbl);
            this.openJobPanel.Location = new System.Drawing.Point(3, 3);
            this.openJobPanel.Name = "openJobPanel";
            this.openJobPanel.Size = new System.Drawing.Size(479, 304);
            this.openJobPanel.TabIndex = 1;
            this.openJobPanel.Visible = false;
            // 
            // openJobScript
            // 
            this.openJobScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.openJobScript.Location = new System.Drawing.Point(16, 185);
            this.openJobScript.Name = "openJobScript";
            this.openJobScript.Size = new System.Drawing.Size(445, 100);
            this.openJobScript.TabIndex = 10;
            this.openJobScript.Text = "print(\"Hello, world!\")";
            // 
            // scriptLbl
            // 
            this.scriptLbl.AutoSize = true;
            this.scriptLbl.Location = new System.Drawing.Point(13, 169);
            this.scriptLbl.Name = "scriptLbl";
            this.scriptLbl.Size = new System.Drawing.Size(37, 13);
            this.scriptLbl.TabIndex = 9;
            this.scriptLbl.Text = "Script:";
            // 
            // openJobCores
            // 
            this.openJobCores.Location = new System.Drawing.Point(16, 146);
            this.openJobCores.Name = "openJobCores";
            this.openJobCores.Size = new System.Drawing.Size(155, 20);
            this.openJobCores.TabIndex = 8;
            this.openJobCores.Text = "1";
            // 
            // coresLbl
            // 
            this.coresLbl.AutoSize = true;
            this.coresLbl.Location = new System.Drawing.Point(13, 130);
            this.coresLbl.Name = "coresLbl";
            this.coresLbl.Size = new System.Drawing.Size(37, 13);
            this.coresLbl.TabIndex = 7;
            this.coresLbl.Text = "Cores:";
            // 
            // openJobCategory
            // 
            this.openJobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.openJobCategory.FormattingEnabled = true;
            this.openJobCategory.Items.AddRange(new object[] {
            "0"});
            this.openJobCategory.Location = new System.Drawing.Point(16, 106);
            this.openJobCategory.Name = "openJobCategory";
            this.openJobCategory.Size = new System.Drawing.Size(155, 21);
            this.openJobCategory.TabIndex = 6;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(13, 90);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(52, 13);
            this.categoryLbl.TabIndex = 5;
            this.categoryLbl.Text = "Category:";
            // 
            // openJobExpiration
            // 
            this.openJobExpiration.Location = new System.Drawing.Point(16, 67);
            this.openJobExpiration.Name = "openJobExpiration";
            this.openJobExpiration.Size = new System.Drawing.Size(155, 20);
            this.openJobExpiration.TabIndex = 4;
            this.openJobExpiration.Text = "600";
            // 
            // expirationLbl
            // 
            this.expirationLbl.AutoSize = true;
            this.expirationLbl.Location = new System.Drawing.Point(13, 51);
            this.expirationLbl.Name = "expirationLbl";
            this.expirationLbl.Size = new System.Drawing.Size(116, 13);
            this.expirationLbl.TabIndex = 3;
            this.expirationLbl.Text = "Expiration (in seconds):";
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
            // openJobId
            // 
            this.openJobId.Location = new System.Drawing.Point(16, 28);
            this.openJobId.Name = "openJobId";
            this.openJobId.Size = new System.Drawing.Size(155, 20);
            this.openJobId.TabIndex = 1;
            this.openJobId.Text = "Test";
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
            this.logBox.BackColor = System.Drawing.SystemColors.Window;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Location = new System.Drawing.Point(12, 331);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(776, 85);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "Log";
            // 
            // createdByLbl
            // 
            this.createdByLbl.AutoSize = true;
            this.createdByLbl.Location = new System.Drawing.Point(9, 428);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(381, 13);
            this.createdByLbl.TabIndex = 9;
            this.createdByLbl.Text = "Created by pos0#0998. March 17 2023 build. https://github.com/p0s0/SoapUI";
            // 
            // renewJobPanel
            // 
            this.renewJobPanel.Controls.Add(this.renewExpiration);
            this.renewJobPanel.Controls.Add(this.expirationLbl2);
            this.renewJobPanel.Controls.Add(this.renewJobId);
            this.renewJobPanel.Controls.Add(this.jobIdLbl2);
            this.renewJobPanel.Location = new System.Drawing.Point(3, 3);
            this.renewJobPanel.Name = "renewJobPanel";
            this.renewJobPanel.Size = new System.Drawing.Size(479, 304);
            this.renewJobPanel.TabIndex = 11;
            this.renewJobPanel.Visible = false;
            // 
            // renewExpiration
            // 
            this.renewExpiration.Location = new System.Drawing.Point(16, 67);
            this.renewExpiration.Name = "renewExpiration";
            this.renewExpiration.Size = new System.Drawing.Size(155, 20);
            this.renewExpiration.TabIndex = 4;
            this.renewExpiration.Text = "600";
            // 
            // expirationLbl2
            // 
            this.expirationLbl2.AutoSize = true;
            this.expirationLbl2.Location = new System.Drawing.Point(13, 51);
            this.expirationLbl2.Name = "expirationLbl2";
            this.expirationLbl2.Size = new System.Drawing.Size(116, 13);
            this.expirationLbl2.TabIndex = 3;
            this.expirationLbl2.Text = "Expiration (in seconds):";
            // 
            // renewJobId
            // 
            this.renewJobId.Location = new System.Drawing.Point(16, 28);
            this.renewJobId.Name = "renewJobId";
            this.renewJobId.Size = new System.Drawing.Size(155, 20);
            this.renewJobId.TabIndex = 1;
            this.renewJobId.Text = "Test";
            // 
            // jobIdLbl2
            // 
            this.jobIdLbl2.AutoSize = true;
            this.jobIdLbl2.Location = new System.Drawing.Point(13, 12);
            this.jobIdLbl2.Name = "jobIdLbl2";
            this.jobIdLbl2.Size = new System.Drawing.Size(41, 13);
            this.jobIdLbl2.TabIndex = 0;
            this.jobIdLbl2.Text = "Job ID:";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdByLbl);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Text = "SoapUI";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.openJobPanel.ResumeLayout(false);
            this.openJobPanel.PerformLayout();
            this.renewJobPanel.ResumeLayout(false);
            this.renewJobPanel.PerformLayout();
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
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label createdByLbl;
        private System.Windows.Forms.Panel openJobPanel;
        private System.Windows.Forms.Label jobIdLbl;
        private System.Windows.Forms.TextBox openJobId;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Label expirationLbl;
        private System.Windows.Forms.TextBox openJobExpiration;
        private System.Windows.Forms.ComboBox openJobCategory;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label coresLbl;
        private System.Windows.Forms.TextBox openJobCores;
        private System.Windows.Forms.Label scriptLbl;
        private System.Windows.Forms.RichTextBox openJobScript;
        private System.Windows.Forms.Panel renewJobPanel;
        private System.Windows.Forms.TextBox renewExpiration;
        private System.Windows.Forms.Label expirationLbl2;
        private System.Windows.Forms.TextBox renewJobId;
        private System.Windows.Forms.Label jobIdLbl2;
    }
}

