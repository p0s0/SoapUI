using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameServer.SOAP;
using System.Xml.Linq;

namespace SoapUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            logBox.Clear();
        }

        public bool AddToLog(string logText)
        {
            logBox.AppendText(logText + "\r\n");

            return true;
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

                        MessageBox.Show("Version: " + response.version + "\r\nEnvrionment count: " + response.environmentCount, "GetStatus Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "OpenJobEx": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "OpenJobEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "RenewLease":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "RenewLeaseResult").FirstOrDefault();

                        MessageBox.Show(response.FirstNode.ToString(), "RenewLease Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "ExecuteEx": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "ExecuteEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "CloseJob": // This doesn't have an actual response, let's just return a generic "Success!"
                        MessageBox.Show("Success!", "CloseJob Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "DiagEx":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "DiagExResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "DiagEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    case "GetAllJobsEx":
                        response = doc.Descendants().Where(x => x.Name.LocalName == "GetAllJobsExResult").FirstOrDefault();

                        MessageBox.Show(response.ToString(), "GetAllJobsEx Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            Enabled = false;

            switch(itemText)
            {
                case "HelloWorld":
                    ParseXML(HelloWorld(int.Parse(port.Text), baseUrl.Text), "HelloWorld");
                    break;
                case "GetVersion":
                    ParseXML(GetVersion(int.Parse(port.Text), baseUrl.Text), "GetVersion");
                    break;
                case "GetStatus":
                    ParseXML(GetStatus(int.Parse(port.Text), baseUrl.Text), "GetStatus");
                    break;
                case "OpenJobEx":
                    ParseXML(OpenJobEx(int.Parse(port.Text), new GameServer.Rcc.Job(openJobId.Text, Double.Parse(openJobExpiration.Text), openJobCategory.SelectedIndex, Double.Parse(openJobCores.Text)), new GameServer.Rcc.Classes.Script("GameServer", openJobScript.Text), baseUrl.Text), "OpenJobEx");
                    break;
                case "RenewLease":
                    ParseXML(RenewLease(int.Parse(port.Text), renewJobId.Text, Double.Parse(renewExpiration.Text), baseUrl.Text), "RenewLease");
                    break;
                case "ExecuteEx":
                    ParseXML(ExecuteEx(int.Parse(port.Text), executeJobId.Text, new GameServer.Rcc.Classes.Script("ExecuteEx", executeScript.Text), baseUrl.Text), "ExecuteEx");
                    break;
                case "CloseJob":
                    ParseXML(CloseJob(int.Parse(port.Text), closeJobId.Text, baseUrl.Text), "CloseJob");
                    break;
                case "DiagEx":
                    ParseXML(DiagEx(int.Parse(port.Text), int.Parse(diagExType.Text), diagExJobId.Text, baseUrl.Text), "DiagEx");
                    break;
                case "GetAllJobsEx":
                    ParseXML(GetAllJobsEx(int.Parse(port.Text), baseUrl.Text), "GetAllJobsEx");
                    break;
                case "CloseExpiredJobs":
                    ParseXML(CloseExpiredJobs(int.Parse(port.Text), baseUrl.Text), "CloseExpiredJobs");
                    break;
                case "CloseAllJobs":
                    ParseXML(CloseAllJobs(int.Parse(port.Text), baseUrl.Text), "CloseAllJobs");
                    break;
                default:
                    AddToLog("Invalid SOAPAction " + itemText);
                    MessageBox.Show("Sorry, the SOAPAction " + itemText + " is currently not implemented.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            Enabled = true;
        }

        private void soapAction_SelectedValueChanged(object sender, EventArgs e)
        {
            noExtraInfoLbl.Visible = false;
            openJobPanel.Visible = false;
            renewJobPanel.Visible = false;
            executePanel.Visible = false;
            closeJobPanel.Visible = false;
            diagExPanel.Visible = false;

            switch (soapAction.GetItemText(soapAction.SelectedItem))
            {
                case "OpenJobEx":
                    openJobPanel.Visible = true;
                    break;
                case "RenewLease":
                    renewJobPanel.Visible = true;
                    break;
                case "ExecuteEx":
                    executePanel.Visible = true;
                    break;
                case "CloseJob":
                    closeJobPanel.Visible = true;
                    break;
                case "DiagEx":
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
    }
}
