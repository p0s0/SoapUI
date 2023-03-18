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
                    default:
                        AddToLog("Attempt to call ParseXML(string xml, string soapAction) with invalid arguments");
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
                    OpenJobEx(int.Parse(port.Text), new GameServer.Rcc.Job(openJobId.Text, Double.Parse(openJobExpiration.Text), openJobCategory.SelectedIndex, Double.Parse(openJobCores.Text)), new GameServer.Rcc.Classes.Script("GameServer", openJobScript.Text), baseUrl.Text);
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

            switch (soapAction.GetItemText(soapAction.SelectedItem))
            {
                case "OpenJobEx":
                    openJobPanel.Visible = true;
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
