using System;
using System.Data;
using System.Linq;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using static GameServer.SOAP;
using System.Collections.Generic;
using SoapUI.Rcc.Classes;
using System.IO;
using Newtonsoft.Json;

namespace SoapUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            logBox.Clear();
            logBox.Size = new System.Drawing.Size(776, 85);
        }

        public bool AddToLog(string logText)
        {
            logBox.AppendText(logText + "\r\n");

            return true;
        }

        private List<LuaValueNew> GetLuaValues()
        {
            List<LuaValueNew> list = new List<LuaValueNew>();

            foreach(Control control in scriptArgumentPanel.Controls)
            {
                if (control.Name == "argumentTemplate" && control.Visible)
                {
                    list.Add(new LuaValueNew(control.Controls["argumentType"].Text, control.Controls["argumentValue"].Text));
                }
            }

            return list;
        }

        public void ParseXML(string xml, string soapAction)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                dynamic response = null;

                switch (soapAction)
                {
                    case "HelloWorld":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "HelloWorldResult").FirstOrDefault();

                        MessageBox.Show(response.FirstNode.ToString(), "HelloWorld Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "GetVersion":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetVersionResult").FirstOrDefault();

                        MessageBox.Show(response.FirstNode.ToString(), "GetVersion Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "GetStatus":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetStatusResult").Select(x => new XmlResponses.Status()
                        {
                            version = (string)x.Element(x.Name.Namespace + "version"),
                            environmentCount = (int)x.Element(x.Name.Namespace + "environmentCount")
                        }).FirstOrDefault();

                        MessageBox.Show("Version: " + response.version + "\r\nEnvironment count: " + response.environmentCount, "GetStatus Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "OpenJobEx": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "OpenJobEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "OpenJob": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "OpenJob Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "RenewLease":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "RenewLeaseResult").FirstOrDefault();

                        MessageBox.Show(response.FirstNode.ToString(), "RenewLease Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "ExecuteEx": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "ExecuteEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "Execute": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "Execute Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "CloseJob": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "CloseJob Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "DiagEx":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "DiagExResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "DiagEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "Diag":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "DiagResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "Diag Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "GetAllJobsEx":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetAllJobsExResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "GetAllJobsEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "GetAllJobs":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetAllJobsResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "GetAllJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "CloseExpiredJobs":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "CloseExpiredJobsResult").FirstOrDefault();

                        MessageBox.Show("Jobs closed: " + response.FirstNode.ToString(), "CloseExpiredJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "CloseAllJobs":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "CloseAllJobsResult").FirstOrDefault();

                        MessageBox.Show("Jobs closed: " + response.FirstNode.ToString(), "CloseAllJobs Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    default:
                        MessageBox.Show("Attempt to call ParseXML(string xml, string soapAction) with invalid arguments", "ParseXML(string xml, string soapAction) error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            } catch (XmlException e)
            {
                MessageBox.Show("Error whilst parsing XML: " + e.Message, "ParseXML(string xml, string soapAction) error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            string itemText = soapAction.GetItemText(soapAction.SelectedItem);

            AddToLog("Attempting to execute " + itemText);

            try
            {
                Enabled = false;

                switch (itemText)
                {
                    case "HelloWorld":
                        ParseXML(HelloWorld(int.Parse(port.Text), baseUrl.Text, ip.Text), "HelloWorld");
                        break;
                    case "GetVersion":
                        ParseXML(GetVersion(int.Parse(port.Text), baseUrl.Text, ip.Text), "GetVersion");
                        break;
                    case "GetStatus":
                        ParseXML(GetStatus(int.Parse(port.Text), baseUrl.Text, ip.Text), "GetStatus");
                        break;
                    case "OpenJobEx":
                        ParseXML(OpenJobEx(int.Parse(port.Text), new GameServer.Rcc.Job(openJobId.Text, Double.Parse(openJobExpiration.Text), openJobCategory.SelectedIndex, Double.Parse(openJobCores.Text)), new GameServer.Rcc.Classes.Script("GameServer", openJobScript.Text, GetLuaValues()), baseUrl.Text, ip.Text), "OpenJobEx");
                        break;
                    case "OpenJob":
                        ParseXML(OpenJob(int.Parse(port.Text), new GameServer.Rcc.Job(openJobId.Text, Double.Parse(openJobExpiration.Text), openJobCategory.SelectedIndex, Double.Parse(openJobCores.Text)), new GameServer.Rcc.Classes.Script("GameServer", openJobScript.Text, GetLuaValues()), baseUrl.Text, ip.Text), "OpenJob");
                        break;
                    case "RenewLease":
                        ParseXML(RenewLease(int.Parse(port.Text), renewJobId.Text, Double.Parse(renewExpiration.Text), baseUrl.Text, ip.Text), "RenewLease");
                        break;
                    case "ExecuteEx":
                        ParseXML(ExecuteEx(int.Parse(port.Text), executeJobId.Text, new GameServer.Rcc.Classes.Script("ExecuteEx", executeScript.Text, GetLuaValues()), baseUrl.Text, ip.Text), "ExecuteEx");
                        break;
                    case "Execute":
                        ParseXML(Execute(int.Parse(port.Text), executeJobId.Text, new GameServer.Rcc.Classes.Script("ExecuteEx", executeScript.Text, GetLuaValues()), baseUrl.Text, ip.Text), "Execute");
                        break;
                    case "CloseJob":
                        ParseXML(CloseJob(int.Parse(port.Text), closeJobId.Text, baseUrl.Text, ip.Text), "CloseJob");
                        break;
                    case "DiagEx":
                        ParseXML(DiagEx(int.Parse(port.Text), int.Parse(diagExType.Text), diagExJobId.Text, baseUrl.Text, ip.Text), "DiagEx");
                        break;
                    case "Diag":
                        ParseXML(Diag(int.Parse(port.Text), int.Parse(diagExType.Text), diagExJobId.Text, baseUrl.Text, ip.Text), "Diag");
                        break;
                    case "GetAllJobsEx":
                        ParseXML(GetAllJobsEx(int.Parse(port.Text), baseUrl.Text, ip.Text), "GetAllJobsEx");
                        break;
                    case "GetAllJobs":
                        ParseXML(GetAllJobs(int.Parse(port.Text), baseUrl.Text, ip.Text), "GetAllJobs");
                        break;
                    case "CloseExpiredJobs":
                        ParseXML(CloseExpiredJobs(int.Parse(port.Text), baseUrl.Text, ip.Text), "CloseExpiredJobs");
                        break;
                    case "CloseAllJobs":
                        ParseXML(CloseAllJobs(int.Parse(port.Text), baseUrl.Text, ip.Text), "CloseAllJobs");
                        break;
                    default:
                        AddToLog("Invalid SOAPAction " + itemText);
                        MessageBox.Show("Sorry, the SOAPAction " + itemText + " is currently not implemented.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                Enabled = true;
            } catch (Exception err)
            {
                AddToLog("Error whilst executing SOAPAction: " + err.Message);
                MessageBox.Show("Error: " + err.Message, "Error whilst executing SOAPAction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Enabled = true;
            }
        }

        private void soapAction_SelectedValueChanged(object sender, EventArgs e)
        {
            noExtraInfoLbl.Visible = false;
            openJobPanel.Visible = false;
            renewJobPanel.Visible = false;
            executePanel.Visible = false;
            closeJobPanel.Visible = false;
            diagExPanel.Visible = false;
            scriptArgumentPanel.Visible = false;
            loadScriptBtn.Visible = false;
            logBox.Size = new System.Drawing.Size(776, 85);

            switch (soapAction.GetItemText(soapAction.SelectedItem))
            {
                case "OpenJobEx":
                    openJobPanel.Visible = true;
                    scriptArgumentPanel.Visible = true;
                    loadScriptBtn.Visible = true;
                    logBox.Size = new System.Drawing.Size(282, 85);
                    break;
                case "OpenJob":
                    openJobPanel.Visible = true;
                    scriptArgumentPanel.Visible = true;
                    loadScriptBtn.Visible = true;
                    logBox.Size = new System.Drawing.Size(282, 85);
                    break;
                case "RenewLease":
                    renewJobPanel.Visible = true;
                    break;
                case "ExecuteEx":
                    executePanel.Visible = true;
                    scriptArgumentPanel.Visible = true;
                    loadScriptBtn.Visible = true;
                    logBox.Size = new System.Drawing.Size(282, 85);
                    break;
                case "Execute":
                    executePanel.Visible = true;
                    scriptArgumentPanel.Visible = true;
                    loadScriptBtn.Visible = true;
                    logBox.Size = new System.Drawing.Size(282, 85);
                    break;
                case "CloseJob":
                    closeJobPanel.Visible = true;
                    break;
                case "DiagEx":
                    diagExPanel.Visible = true;
                    break;
                case "Diag":
                    diagExPanel.Visible = true;
                    break;
                default:
                    noExtraInfoLbl.Visible = true;
                    break;
            }
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            openJobId.Text = GameServer.Utility.GenerateGUID();
        }

        private void repoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/p0s0/SoapUI");
            repoLink.LinkVisited = true;
        }

        private int currentY = 4;

        private void addArgumentPanel(dynamic type = null, dynamic value = null)
        {
            Panel newArgumentPanel = new MainUI().argumentTemplate;

            newArgumentPanel.Controls["argumentType"].Text = type;
            newArgumentPanel.Controls["argumentValue"].Text = value;

            newArgumentPanel.Location = new System.Drawing.Point(4, currentY);
            newArgumentPanel.Visible = true;

            scriptArgumentPanel.Controls.Add(newArgumentPanel);

            scriptArgumentPanel.AutoScroll = false;
            scriptArgumentPanel.HorizontalScroll.Enabled = false;
            scriptArgumentPanel.HorizontalScroll.Visible = false;
            scriptArgumentPanel.HorizontalScroll.Maximum = 0;
            scriptArgumentPanel.AutoScroll = true;

            currentY += 33;
        }

        private void addArgumentButton_Click(object sender, EventArgs e)
        {
            addArgumentPanel("LUA_TNIL");
        }

        private void removeArgument_Click(object sender, EventArgs e)
        {
            currentY -= 33;
            int y = removeArgument.Location.Y;

            foreach (Control item in removeArgument.Parent.Parent.Controls)
            {
                if (item.Name == "argumentTemplate" && item != removeArgument.Parent && item.Visible && item.Location.Y > y)
                {
                    item.Location = new System.Drawing.Point(item.Location.X, item.Location.Y - 33);
                }
            }

            removeArgument.Parent.Parent.Controls.Remove(removeArgument.Parent);
        }

        private void openArgsFromFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog argDialog = new OpenFileDialog();

            argDialog.Filter = "Text files (*.txt)|*.txt|JSON files (*.json)|*.json";
            argDialog.Title = "Please pick a valid text or JSON file";
            argDialog.CheckFileExists = true;
            argDialog.CheckPathExists = true;

            DialogResult result = argDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                foreach (Control item in scriptArgumentPanel.Controls)
                {
                    if (item.Name == "argumentTemplate" && item.Visible)
                    {
                        scriptArgumentPanel.Controls.Remove(item);
                    }
                }

                currentY = 4;

                string file = File.ReadAllText(argDialog.FileName);

                dynamic arguments = JsonConvert.DeserializeObject(file);

                foreach(dynamic argument in arguments)
                {
                    addArgumentPanel(argument.type, argument.value);
                }

                argDialog.Dispose();
            }
        }

        private void saveArgsToFileBtn_Click(object sender, EventArgs e)
        {
            List<LuaValueNew> list = GetLuaValues();

            string serialized = JsonConvert.SerializeObject(list);

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + secondsSinceEpoch + ".json", serialized);

            AddToLog("Wrote arguments to " + Path.GetDirectoryName(Application.ExecutablePath) + "\\" + secondsSinceEpoch + ".json!");
        }

        private void loadScriptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog scriptDialog = new OpenFileDialog();

            scriptDialog.Filter = "Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua";
            scriptDialog.Title = "Please pick a valid text or lua file";
            scriptDialog.CheckFileExists = true;
            scriptDialog.CheckPathExists = true;

            DialogResult result = scriptDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = File.ReadAllText(scriptDialog.FileName);
                string itemText = soapAction.GetItemText(soapAction.SelectedItem);

                switch(itemText)
                {
                    case "OpenJobEx":
                        openJobScript.Text = file;
                        break;
                    case "ExecuteEx":
                        executeScript.Text = file;
                        break;
                    default:
                        MessageBox.Show("Invalid SOAPAction to load script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                scriptDialog.Dispose();
            }
        }
    }
}
