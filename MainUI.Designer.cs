
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.soapLbl = new System.Windows.Forms.Label();
            this.soapAction = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.soapAction);
            this.panel1.Controls.Add(this.soapLbl);
            this.panel1.Controls.Add(this.ip);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.portLbl);
            this.panel1.Controls.Add(this.ipLbl);
            this.panel1.Controls.Add(this.baseUrl);
            this.panel1.Controls.Add(this.baseUrlLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 185);
            this.panel1.TabIndex = 6;
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
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainUI";
            this.Text = "SoapUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label baseUrlLbl;
        private System.Windows.Forms.TextBox baseUrl;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox soapAction;
        private System.Windows.Forms.Label soapLbl;
    }
}

