
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.baseUrlLbl = new System.Windows.Forms.Label();
            this.baseUrl = new System.Windows.Forms.TextBox();
            this.ipLbl = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.loadScriptBtn = new System.Windows.Forms.Button();
            this.executeBtn = new System.Windows.Forms.Button();
            this.soapAction = new System.Windows.Forms.ComboBox();
            this.soapLbl = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.diagExPanel = new System.Windows.Forms.Panel();
            this.diagExType = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.diagExJobId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeJobPanel = new System.Windows.Forms.Panel();
            this.closeJobId = new System.Windows.Forms.TextBox();
            this.jobIdLbl4 = new System.Windows.Forms.Label();
            this.executePanel = new System.Windows.Forms.Panel();
            this.scriptLbl2 = new System.Windows.Forms.Label();
            this.executeScript = new System.Windows.Forms.RichTextBox();
            this.executeJobId = new System.Windows.Forms.TextBox();
            this.jobIdLbl3 = new System.Windows.Forms.Label();
            this.renewJobPanel = new System.Windows.Forms.Panel();
            this.renewExpiration = new System.Windows.Forms.TextBox();
            this.expirationLbl2 = new System.Windows.Forms.Label();
            this.renewJobId = new System.Windows.Forms.TextBox();
            this.jobIdLbl2 = new System.Windows.Forms.Label();
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
            this.repoLink = new System.Windows.Forms.LinkLabel();
            this.scriptArgumentPanel = new System.Windows.Forms.Panel();
            this.saveArgsToFileBtn = new System.Windows.Forms.Button();
            this.openArgsFromFileBtn = new System.Windows.Forms.Button();
            this.addArgumentButton = new System.Windows.Forms.Button();
            this.argumentTemplate = new System.Windows.Forms.Panel();
            this.removeArgument = new System.Windows.Forms.Button();
            this.argumentValue = new System.Windows.Forms.TextBox();
            this.argumentType = new System.Windows.Forms.ComboBox();
            this.settingsPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.diagExPanel.SuspendLayout();
            this.closeJobPanel.SuspendLayout();
            this.executePanel.SuspendLayout();
            this.renewJobPanel.SuspendLayout();
            this.openJobPanel.SuspendLayout();
            this.scriptArgumentPanel.SuspendLayout();
            this.argumentTemplate.SuspendLayout();
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
            this.settingsPanel.Controls.Add(this.loadScriptBtn);
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
            // loadScriptBtn
            // 
            this.loadScriptBtn.Location = new System.Drawing.Point(13, 201);
            this.loadScriptBtn.Name = "loadScriptBtn";
            this.loadScriptBtn.Size = new System.Drawing.Size(255, 23);
            this.loadScriptBtn.TabIndex = 9;
            this.loadScriptBtn.Text = "Load Script";
            this.loadScriptBtn.UseVisualStyleBackColor = true;
            this.loadScriptBtn.Visible = false;
            this.loadScriptBtn.Click += new System.EventHandler(this.loadScriptBtn_Click);
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
            "OpenJob",
            "RenewLease",
            "ExecuteEx",
            "Execute",
            "CloseJob",
            "DiagEx",
            "Diag",
            "GetAllJobsEx",
            "GetAllJobs",
            "CloseExpiredJobs",
            "CloseAllJobs"});
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
            this.actionPanel.Controls.Add(this.diagExPanel);
            this.actionPanel.Controls.Add(this.closeJobPanel);
            this.actionPanel.Controls.Add(this.executePanel);
            this.actionPanel.Controls.Add(this.renewJobPanel);
            this.actionPanel.Controls.Add(this.openJobPanel);
            this.actionPanel.Controls.Add(this.noExtraInfoLbl);
            this.actionPanel.Location = new System.Drawing.Point(301, 12);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(487, 312);
            this.actionPanel.TabIndex = 7;
            // 
            // diagExPanel
            // 
            this.diagExPanel.Controls.Add(this.diagExType);
            this.diagExPanel.Controls.Add(this.typeLbl);
            this.diagExPanel.Controls.Add(this.diagExJobId);
            this.diagExPanel.Controls.Add(this.label1);
            this.diagExPanel.Location = new System.Drawing.Point(3, 3);
            this.diagExPanel.Name = "diagExPanel";
            this.diagExPanel.Size = new System.Drawing.Size(479, 304);
            this.diagExPanel.TabIndex = 14;
            this.diagExPanel.Visible = false;
            // 
            // diagExType
            // 
            this.diagExType.Location = new System.Drawing.Point(16, 66);
            this.diagExType.Name = "diagExType";
            this.diagExType.Size = new System.Drawing.Size(155, 20);
            this.diagExType.TabIndex = 3;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(13, 51);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(34, 13);
            this.typeLbl.TabIndex = 2;
            this.typeLbl.Text = "Type:";
            // 
            // diagExJobId
            // 
            this.diagExJobId.Location = new System.Drawing.Point(16, 28);
            this.diagExJobId.Name = "diagExJobId";
            this.diagExJobId.Size = new System.Drawing.Size(155, 20);
            this.diagExJobId.TabIndex = 1;
            this.diagExJobId.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID:";
            // 
            // closeJobPanel
            // 
            this.closeJobPanel.Controls.Add(this.closeJobId);
            this.closeJobPanel.Controls.Add(this.jobIdLbl4);
            this.closeJobPanel.Location = new System.Drawing.Point(3, 3);
            this.closeJobPanel.Name = "closeJobPanel";
            this.closeJobPanel.Size = new System.Drawing.Size(479, 304);
            this.closeJobPanel.TabIndex = 13;
            this.closeJobPanel.Visible = false;
            // 
            // closeJobId
            // 
            this.closeJobId.Location = new System.Drawing.Point(16, 28);
            this.closeJobId.Name = "closeJobId";
            this.closeJobId.Size = new System.Drawing.Size(155, 20);
            this.closeJobId.TabIndex = 1;
            this.closeJobId.Text = "Test";
            // 
            // jobIdLbl4
            // 
            this.jobIdLbl4.AutoSize = true;
            this.jobIdLbl4.Location = new System.Drawing.Point(13, 12);
            this.jobIdLbl4.Name = "jobIdLbl4";
            this.jobIdLbl4.Size = new System.Drawing.Size(41, 13);
            this.jobIdLbl4.TabIndex = 0;
            this.jobIdLbl4.Text = "Job ID:";
            // 
            // executePanel
            // 
            this.executePanel.Controls.Add(this.scriptLbl2);
            this.executePanel.Controls.Add(this.executeScript);
            this.executePanel.Controls.Add(this.executeJobId);
            this.executePanel.Controls.Add(this.jobIdLbl3);
            this.executePanel.Location = new System.Drawing.Point(3, 3);
            this.executePanel.Name = "executePanel";
            this.executePanel.Size = new System.Drawing.Size(479, 304);
            this.executePanel.TabIndex = 12;
            this.executePanel.Visible = false;
            // 
            // scriptLbl2
            // 
            this.scriptLbl2.AutoSize = true;
            this.scriptLbl2.Location = new System.Drawing.Point(13, 51);
            this.scriptLbl2.Name = "scriptLbl2";
            this.scriptLbl2.Size = new System.Drawing.Size(37, 13);
            this.scriptLbl2.TabIndex = 3;
            this.scriptLbl2.Text = "Script:";
            // 
            // executeScript
            // 
            this.executeScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.executeScript.Location = new System.Drawing.Point(16, 70);
            this.executeScript.Name = "executeScript";
            this.executeScript.Size = new System.Drawing.Size(445, 215);
            this.executeScript.TabIndex = 2;
            this.executeScript.Text = "print(\"Hello, world!\")";
            // 
            // executeJobId
            // 
            this.executeJobId.Location = new System.Drawing.Point(16, 28);
            this.executeJobId.Name = "executeJobId";
            this.executeJobId.Size = new System.Drawing.Size(155, 20);
            this.executeJobId.TabIndex = 1;
            this.executeJobId.Text = "Test";
            // 
            // jobIdLbl3
            // 
            this.jobIdLbl3.AutoSize = true;
            this.jobIdLbl3.Location = new System.Drawing.Point(13, 12);
            this.jobIdLbl3.Name = "jobIdLbl3";
            this.jobIdLbl3.Size = new System.Drawing.Size(41, 13);
            this.jobIdLbl3.TabIndex = 0;
            this.jobIdLbl3.Text = "Job ID:";
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
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
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
            this.logBox.Size = new System.Drawing.Size(282, 85);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "Log";
            // 
            // createdByLbl
            // 
            this.createdByLbl.AutoSize = true;
            this.createdByLbl.Location = new System.Drawing.Point(9, 428);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(205, 13);
            this.createdByLbl.TabIndex = 9;
            this.createdByLbl.Text = "Created by pos0#0998. April 5 2023 build.";
            // 
            // repoLink
            // 
            this.repoLink.AutoSize = true;
            this.repoLink.Location = new System.Drawing.Point(211, 428);
            this.repoLink.Name = "repoLink";
            this.repoLink.Size = new System.Drawing.Size(164, 13);
            this.repoLink.TabIndex = 10;
            this.repoLink.TabStop = true;
            this.repoLink.Text = "https://github.com/p0s0/SoapUI";
            this.repoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.repoLink_LinkClicked);
            // 
            // scriptArgumentPanel
            // 
            this.scriptArgumentPanel.AutoScroll = true;
            this.scriptArgumentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scriptArgumentPanel.Controls.Add(this.saveArgsToFileBtn);
            this.scriptArgumentPanel.Controls.Add(this.openArgsFromFileBtn);
            this.scriptArgumentPanel.Controls.Add(this.addArgumentButton);
            this.scriptArgumentPanel.Controls.Add(this.argumentTemplate);
            this.scriptArgumentPanel.Location = new System.Drawing.Point(301, 331);
            this.scriptArgumentPanel.Name = "scriptArgumentPanel";
            this.scriptArgumentPanel.Size = new System.Drawing.Size(487, 85);
            this.scriptArgumentPanel.TabIndex = 11;
            this.scriptArgumentPanel.Visible = false;
            // 
            // saveArgsToFileBtn
            // 
            this.saveArgsToFileBtn.Location = new System.Drawing.Point(449, 53);
            this.saveArgsToFileBtn.Name = "saveArgsToFileBtn";
            this.saveArgsToFileBtn.Size = new System.Drawing.Size(18, 21);
            this.saveArgsToFileBtn.TabIndex = 3;
            this.saveArgsToFileBtn.Text = "S";
            this.saveArgsToFileBtn.UseVisualStyleBackColor = true;
            this.saveArgsToFileBtn.Click += new System.EventHandler(this.saveArgsToFileBtn_Click);
            // 
            // openArgsFromFileBtn
            // 
            this.openArgsFromFileBtn.Location = new System.Drawing.Point(449, 30);
            this.openArgsFromFileBtn.Name = "openArgsFromFileBtn";
            this.openArgsFromFileBtn.Size = new System.Drawing.Size(18, 21);
            this.openArgsFromFileBtn.TabIndex = 2;
            this.openArgsFromFileBtn.Text = "F";
            this.openArgsFromFileBtn.UseVisualStyleBackColor = true;
            this.openArgsFromFileBtn.Click += new System.EventHandler(this.openArgsFromFileBtn_Click);
            // 
            // addArgumentButton
            // 
            this.addArgumentButton.Location = new System.Drawing.Point(449, 7);
            this.addArgumentButton.Name = "addArgumentButton";
            this.addArgumentButton.Size = new System.Drawing.Size(18, 21);
            this.addArgumentButton.TabIndex = 1;
            this.addArgumentButton.Text = "+";
            this.addArgumentButton.UseVisualStyleBackColor = true;
            this.addArgumentButton.Click += new System.EventHandler(this.addArgumentButton_Click);
            // 
            // argumentTemplate
            // 
            this.argumentTemplate.Controls.Add(this.removeArgument);
            this.argumentTemplate.Controls.Add(this.argumentValue);
            this.argumentTemplate.Controls.Add(this.argumentType);
            this.argumentTemplate.Location = new System.Drawing.Point(4, 4);
            this.argumentTemplate.Name = "argumentTemplate";
            this.argumentTemplate.Size = new System.Drawing.Size(444, 29);
            this.argumentTemplate.TabIndex = 0;
            this.argumentTemplate.Visible = false;
            // 
            // removeArgument
            // 
            this.removeArgument.Location = new System.Drawing.Point(365, 3);
            this.removeArgument.Name = "removeArgument";
            this.removeArgument.Size = new System.Drawing.Size(74, 20);
            this.removeArgument.TabIndex = 2;
            this.removeArgument.Text = "Remove";
            this.removeArgument.UseVisualStyleBackColor = true;
            this.removeArgument.Click += new System.EventHandler(this.removeArgument_Click);
            // 
            // argumentValue
            // 
            this.argumentValue.Location = new System.Drawing.Point(130, 3);
            this.argumentValue.Name = "argumentValue";
            this.argumentValue.Size = new System.Drawing.Size(229, 20);
            this.argumentValue.TabIndex = 1;
            // 
            // argumentType
            // 
            this.argumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.argumentType.FormattingEnabled = true;
            this.argumentType.Items.AddRange(new object[] {
            "LUA_TNIL",
            "LUA_TBOOLEAN",
            "LUA_TNUMBER",
            "LUA_TSTRING",
            "LUA_TTABLE"});
            this.argumentType.Location = new System.Drawing.Point(3, 3);
            this.argumentType.Name = "argumentType";
            this.argumentType.Size = new System.Drawing.Size(121, 21);
            this.argumentType.TabIndex = 0;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scriptArgumentPanel);
            this.Controls.Add(this.repoLink);
            this.Controls.Add(this.createdByLbl);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Text = "SoapUI";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.diagExPanel.ResumeLayout(false);
            this.diagExPanel.PerformLayout();
            this.closeJobPanel.ResumeLayout(false);
            this.closeJobPanel.PerformLayout();
            this.executePanel.ResumeLayout(false);
            this.executePanel.PerformLayout();
            this.renewJobPanel.ResumeLayout(false);
            this.renewJobPanel.PerformLayout();
            this.openJobPanel.ResumeLayout(false);
            this.openJobPanel.PerformLayout();
            this.scriptArgumentPanel.ResumeLayout(false);
            this.argumentTemplate.ResumeLayout(false);
            this.argumentTemplate.PerformLayout();
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
        private System.Windows.Forms.Panel executePanel;
        private System.Windows.Forms.TextBox executeJobId;
        private System.Windows.Forms.Label jobIdLbl3;
        private System.Windows.Forms.Label scriptLbl2;
        private System.Windows.Forms.RichTextBox executeScript;
        private System.Windows.Forms.Panel closeJobPanel;
        private System.Windows.Forms.TextBox closeJobId;
        private System.Windows.Forms.Label jobIdLbl4;
        private System.Windows.Forms.Panel diagExPanel;
        private System.Windows.Forms.TextBox diagExType;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.TextBox diagExJobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel repoLink;
        private System.Windows.Forms.Panel scriptArgumentPanel;
        private System.Windows.Forms.Panel argumentTemplate;
        private System.Windows.Forms.ComboBox argumentType;
        private System.Windows.Forms.TextBox argumentValue;
        private System.Windows.Forms.Button removeArgument;
        private System.Windows.Forms.Button addArgumentButton;
        private System.Windows.Forms.Button openArgsFromFileBtn;
        private System.Windows.Forms.Button saveArgsToFileBtn;
        private System.Windows.Forms.Button loadScriptBtn;
    }
}

