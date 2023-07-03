using GameServer.Rcc;
using GameServer.Rcc.Classes;
using SoapUI.Rcc.Classes;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GameServer
{
    class SOAP
    {
        private static string GenerateContentXML(string baseUrl, string baseContent)
        {
            return "<?xml version=\"1.0\" encoding=\"UTF - 8\"?>\r\n<SOAP-ENV:Envelope xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:SOAP-ENC=\"http://schemas.xmlsoap.org/soap/encoding/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:ns2=\"http://" + baseUrl + "/RCCServiceSoap\" xmlns:ns1=\"http://" + baseUrl + "/\" xmlns:ns3=\"http://" + baseUrl + "/RCCServiceSoap12\">\r\n\t<SOAP-ENV:Body>" + baseContent + "\t</SOAP-ENV:Body>\r\n</SOAP-ENV:Envelope>";
        }
        private static string SendRequestToGameServer(int servicePort, string action, string content, string url, string ip)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    string newContent = GenerateContentXML(url, content);

                    wc.Encoding = Encoding.UTF8;

                    wc.Headers.Add("Accept", "text/xml");
                    wc.Headers.Add("Cache-Control", "no-cache");
                    wc.Headers.Add("Pragma", "no-cache");
                    wc.Headers.Add("SOAPAction", action);

                    string response = wc.UploadString("http://" + ip + ":" + servicePort.ToString(), newContent);

                    MessageBox.Show(response);

                    return response;
                } catch (WebException e)
                {
                    MessageBox.Show("Error whilst sending " + action + " request to service port " + servicePort.ToString() + ": " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    try
                    {
                        using (var stream = e.Response.GetResponseStream())
                        {
                            using (var reader = new StreamReader(stream))
                            {
                                MessageBox.Show(reader.ReadToEnd());
                                return reader.ReadToEnd();
                            }
                        }
                    } catch (WebException e2)
                    {
                        return "Error";
                    }
                }
            }
        }
        private static string ParseArguments(List<LuaValueNew> args = null)
        {
            if(args != null)
            {
                string xmlReturn = "";

                foreach (LuaValueNew value in args)
                {
                    xmlReturn += "<ns1:LuaValue><ns1:type>" + value.type + "</ns1:type><ns1:value>" + value.value + "</ns1:value></ns1:LuaValue>";
                }

                return xmlReturn;
            } else
            {
                return "";
            }
        }
        private static string CreateScriptExecutionModel(Script script = null)
        {
            return "<ns1:script>\r\n\t\t\t<ns1:name>" + script.name + "</ns1:name>\r\n\t\t\t<ns1:script>" + script.script + "</ns1:script>\r\n\t\t\t<ns1:arguments>" + ParseArguments(script.arguments) + "</ns1:arguments></ns1:script>";
        }
        private static string CreateJobModel(Job job = null)
        {
            return "<ns1:job>\r\n\t\t\t<ns1:id>" + job.id + "</ns1:id>\r\n\t\t\t<ns1:expirationInSeconds>" + job.expirationInSeconds + "</ns1:expirationInSeconds>\r\n\t\t\t<ns1:category>" + job.category + "</ns1:category>\r\n\t\t\t<ns1:cores>" + job.cores + "</ns1:cores></ns1:job>";
        }
        public static string HelloWorld(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "HelloWorld", "\t\t<ns1:HelloWorld>\r\n\t\t</ns1:HelloWorld>", url, ip);
        }
        public static string GetVersion(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "GetVersion", "\t\t<ns1:GetVersion>\r\n\t\t</ns1:GetVersion>", url, ip);
        }
        public static string GetStatus(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "GetStatus", "\t\t<ns1:GetStatus>\r\n\t\t</ns1:GetStatus>", url, ip);
        }
        public static string OpenJobEx(int servicePort = 64989, Job job = null, Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "OpenJobEx", "\t\t<ns1:OpenJobEx>\r\n\t\t\t" + CreateJobModel(job) + "\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:OpenJobEx>", url, ip);
        }
        public static string RenewLease(int servicePort = 64989, string jobID = "Test", double expirationInSeconds = 600, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "RenewLease", "\t\t<ns1:RenewLease>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t\t<ns1:expirationInSeconds>" + expirationInSeconds + "</ns1:expirationInSeconds>\r\n\t\t</ns1:RenewLease>", url, ip);
        }
        public static string ExecuteEx(int servicePort = 64989, string jobID = "Test", Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "ExecuteEx", "\t\t<ns1:ExecuteEx>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:ExecuteEx>", url, ip);
        }
        public static string ExecuteScript(int servicePort = 64989, string jobID = "Test", Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "Execute", "\t\t<ns1:Execute>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:Execute>", url, ip);
        }
        public static string CloseJob(int servicePort = 64989, string jobID = "Test", string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "CloseJob", "\t\t<ns1:CloseJob>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t</ns1:CloseJob>", url, ip);
        }
        public static string DiagEx(int servicePort = 64989, int type = 0, string jobID = "Test", string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "DiagEx", "\t\t<ns1:DiagEx>\r\n\t\t\t<ns1:type>" + type + "</ns1:type>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t</ns1:DiagEx>", url, ip);
        }
        public static string GetAllJobsEx(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "GetAllJobsEx", "\t\t<ns1:GetAllJobsEx>\r\n\t\t</ns1:GetAllJobsEx>", url, ip);
        }
        public static string CloseExpiredJobs(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "CloseExpiredJobs", "\t\t<ns1:CloseExpiredJobs>\r\n\t\t</ns1:CloseExpiredJobs>", url, ip);
        }
        public static string CloseAllJobs(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "CloseAllJobs", "\t\t<ns1:CloseAllJobs>\r\n\t\t</ns1:CloseAllJobs>", url, ip);
        }
        public static string BatchJobEx(int servicePort = 64989, Job job = null, Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "BatchJobEx", "\t\t<ns1:BatchJobEx>\r\n\t\t\t" + CreateJobModel(job) + "\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:BatchJobEx>", url, ip);
        }
        // deprecated stuff // but we just use new stuff // NEVERMIND WE DONT 2008 RCC DROPPED
        public static string Execute(int servicePort = 64989, string jobID = "Test", Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "Execute", "\t\t<ns1:Execute>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:Execute>", url, ip);
        }
        public static string OpenJob(int servicePort = 64989, Job job = null, Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "OpenJob", "\t\t<ns1:OpenJob>\r\n\t\t\t" + CreateJobModel(job) + "\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:OpenJob>", url, ip);
        }
        public static string BatchJob(int servicePort = 64989, Job job = null, Script script = null, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "BatchJob", "\t\t<ns1:BatchJob>\r\n\t\t\t" + CreateJobModel(job) + "\r\n\t\t\t" + CreateScriptExecutionModel(script) + "\r\n\t\t</ns1:BatchJob>", url, ip);
        }
        public static string Diag(int servicePort = 64989, int type = 0, string jobID = "Test", string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "Diag", "\t\t<ns1:Diag>\r\n\t\t\t<ns1:type>" + type + "</ns1:type>\r\n\t\t\t<ns1:jobID>" + jobID + "</ns1:jobID>\r\n\t\t</ns1:Diag>", url, ip);
        }
        public static string GetAllJobs(int servicePort = 64989, string url = "roblox.com", string ip = "127.0.0.1")
        {
            return SendRequestToGameServer(servicePort, "GetAllJobs", "\t\t<ns1:GetAllJobs>\r\n\t\t</ns1:GetAllJobs>", url, ip);
        }
    }
}
