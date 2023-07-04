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
       public string[] rbxgsItems = new string[]
       {
            "GetStandardOutMessages",
            "GetAllEnvironments",
            "Execute",
            "CloseAllEnvironments",
            "CloseOrphanedEnvironments",
            "CloseEnvironment",
            "OpenEnvironment",
            "Update",
            "GetStatus",
            "GetVersion",
            "HelloWorld"
        };

        public string[] rccItems = new string[]
        {
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
            "CloseAllJobs"
         };

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

                switch (soapAction) // jesus christ this is messy
                {
                    case "HelloWorld":
                        if(rbxgsMode.Checked)
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "HelloWorld").FirstOrDefault();

                            MessageBox.Show(response.FirstNode.Value.ToString(), "HelloWorld Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "HelloWorldResult").FirstOrDefault();

                            MessageBox.Show(response.FirstNode.ToString(), "HelloWorld Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    case "GetVersion":
                        if(rbxgsMode.Checked)
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "GetVersion").FirstOrDefault().Element("return").Value;

                            AddToLog("Version: " + response);

                            MessageBox.Show(response, "GetVersion Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "GetVersionResult").FirstOrDefault();

                            MessageBox.Show(response.FirstNode.ToString(), "GetVersion Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    case "GetStatus":
                        if(rbxgsMode.Checked)
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "GetStatus").FirstOrDefault().Element("return");

                            dynamic webServiceVersion = response.Element("version").Value;
                            dynamic environmentCount = response.Element("environmentCount").Value;

                            AddToLog("Version: " + webServiceVersion);
                            AddToLog("Environment count: " + environmentCount);

                            MessageBox.Show("Version: " + webServiceVersion + "\r\nEnvironment count: " + environmentCount, "GetStatus Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "GetStatusResult").Select(x => new XmlResponses.Status()
                            {
                                version = (string)x.Element(x.Name.Namespace + "version"),
                                environmentCount = (int)x.Element(x.Name.Namespace + "environmentCount")
                            }).FirstOrDefault();

                            MessageBox.Show("Version: " + response.version + "\r\nEnvironment count: " + response.environmentCount, "GetStatus Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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
                    case "Execute":
                        if(rbxgsMode.Checked)
                        {
                            response = doc.Descendants().Where(x => x.Name.LocalName == "Execute").FirstOrDefault().Element("return");

                            dynamic returnCount = response.Element("count").Value;
                            dynamic returnValues = response.Element("items").Elements();

                            AddToLog("Return value count: " + returnCount);

                            foreach (XElement item in returnValues)
                            {
                                if (item.Name.ToString() != "count")
                                {
                                    string prefix = "[UNKNOWN TYPE] ";

                                    switch (item.Element("type").Value)
                                    {
                                        case "LUA_TNIL":
                                            prefix = "[NIL] ";
                                            break;
                                        case "LUA_TBOOLEAN":
                                            prefix = "[BOOLEAN] ";
                                            break;
                                        case "LUA_TNUMBER":
                                            prefix = "[NUMBER] ";
                                            break;
                                        case "LUA_TSTRING":
                                            prefix = "[STRING] ";
                                            break;
                                        case "LUA_TTABLE":
                                            prefix = "[TABLE] ";
                                            break;
                                        default:
                                            break;
                                    }

                                    AddToLog(prefix + item.Element("value").Value.ToString());
                                }
                            }
                        } else
                        {
                            MessageBox.Show("Success!", "Execute Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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
                    case "OpenEnvironment":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "OpenEnvironment").FirstOrDefault().Element("return");

                        AddToLog("Opened Environment " + response.Value);

                        MessageBox.Show("Success", "Open Environment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "CloseEnvironment":
                        AddToLog("Closed environment");

                        break;
                    case "CloseOrphanedEnvironments":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "CloseOrphanedEnvironments").FirstOrDefault().Element("return");

                        AddToLog("Closed " + response.Value + " orphaned environments");

                        break;
                    case "CloseAllEnvironments":
                        AddToLog("Closed all environments");

                        break;
                    case "GetAllEnvironments":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetAllEnvironments").FirstOrDefault().Element("return");

                        AddToLog("Environment count: " + response.Element("count").Value);

                        foreach(XElement item in response.Element("items").Elements())
                        {
                            AddToLog(item.Value);
                        }

                        break;
                    case "GetStandardOutMessages":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetStandardOutMessages").FirstOrDefault().Element("return");

                        dynamic messageCount = response.Element("count").Value;
                        dynamic messages = response.Element("items").Elements();

                        AddToLog("Message count: " + messageCount);

                        foreach(XElement item in messages)
                        {
                            if(item.Name.ToString() != "count")
                            {
                                string prefix = "[UNKNOWN] ";

                                switch (item.Element("type").Value)
                                {
                                    case "MESSAGE_OUTPUT":
                                        prefix = "[OUTPUT] ";
                                        break;
                                    case "MESSAGE_INFO":
                                        prefix = "[INFO] ";
                                        break;
                                    case "MESSAGE_WARNING":
                                        prefix = "[WARNING] ";
                                        break;
                                    case "MESSAGE_ERROR":
                                        prefix = "[ERROR] ";
                                        break;
                                    default:
                                        break;
                                }

                                AddToLog(new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(int.Parse(item.Element("time").Value)).ToLocalTime().ToString() + " - " + prefix + item.Element("text").Value);
                            }
                        }

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

                switch (itemText) // also messy as hell bruh
                {
                    case "HelloWorld":
                        ParseXML(HelloWorld(int.Parse(port.Text), baseUrl.Text, ip.Text, rbxgsMode.Checked), "HelloWorld");
                        break;
                    case "GetVersion":
                        ParseXML(GetVersion(int.Parse(port.Text), baseUrl.Text, ip.Text, rbxgsMode.Checked), "GetVersion");
                        break;
                    case "GetStatus":
                        ParseXML(GetStatus(int.Parse(port.Text), baseUrl.Text, ip.Text, rbxgsMode.Checked), "GetStatus");
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
                        ParseXML(Execute(int.Parse(port.Text), executeJobId.Text, new GameServer.Rcc.Classes.Script("Execute", executeScript.Text, GetLuaValues(), executeJobId.Text), baseUrl.Text, ip.Text, rbxgsMode.Checked), "Execute");
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
                    // RBXGS
                    case "GetStandardOutMessages":
                        ParseXML(GetStandardOutMessages(ip.Text, 30), "GetStandardOutMessages");
                        break;
                    case "GetAllEnvironments":
                        ParseXML(GetAllEnvironments(ip.Text), "GetAllEnvironments");
                        break;
                    case "OpenEnvironment":
                        ParseXML(OpenEnvironment(ip.Text), "OpenEnvironment");
                        break;
                    case "CloseEnvironment":
                        ParseXML(CloseEnvironment(ip.Text, closeJobId.Text), "CloseEnvironment");
                        break;
                    case "CloseAllEnvironments":
                        ParseXML(CloseAllEnvironments(ip.Text), "CloseAllEnvironments");
                        break;
                    case "CloseOrphanedEnvironments":
                        ParseXML(CloseOrphanedEnvironments(ip.Text), "CloseOrphanedEnvironments");
                        break;
                    case "Update":
                        ParseXML(GameServer.SOAP.Update(ip.Text), "Update");
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

        private void hideAllPanels()
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
        }

        private void soapAction_SelectedValueChanged(object sender, EventArgs e)
        {
            hideAllPanels();

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
                case "CloseEnvironment":
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
                    case "OpenJob":
                        openJobScript.Text = file;
                        break;
                    case "Execute":
                        executeScript.Text = file;
                        break;
                    default:
                        MessageBox.Show("Invalid SOAPAction to load script", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                scriptDialog.Dispose();
            }
        }

        private void rbxgsMode_CheckedChanged(object sender, EventArgs e)
        {
            hideAllPanels();
            soapAction.Items.Clear();

            if (rbxgsMode.Checked)
            {
                foreach (string action in rbxgsItems)
                {
                    soapAction.Items.Add(action);
                }
            } else
            {
                foreach (string action in rccItems)
                {
                    soapAction.Items.Add(action);
                }
            }

            baseUrl.Visible = !rbxgsMode.Checked;
            baseUrlLbl.Visible = !rbxgsMode.Checked;

            port.Visible = !rbxgsMode.Checked;
            portLbl.Visible = !rbxgsMode.Checked;
        }
    }
}
