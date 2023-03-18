using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameServer.SOAP;

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

        private async void executeBtn_Click(object sender, EventArgs e)
        {
            string itemText = soapAction.GetItemText(soapAction.SelectedItem);

            AddToLog("Attempting to execute " + itemText);

            Enabled = false;

            switch(itemText)
            {
                case "HelloWorld":
                    await Task.Run(async () =>
                    {
                        HelloWorld(int.Parse(port.Text));
                    });
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
            switch(soapAction.GetItemText(soapAction.SelectedItem))
            {
                case "OpenJobEx":
                    noExtraInfoLbl.Visible = false;
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
