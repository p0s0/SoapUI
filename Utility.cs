using SoapUI;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace GameServer
{
    class Utility
    {
        public static string GetCurrentWorkingDirectory()
        {
            return Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        }
        
        public static string GetAccessKey()
        {
            if(File.Exists(GetCurrentWorkingDirectory() + "\\AccessKey")) {
                return File.ReadAllText(GetCurrentWorkingDirectory() + "\\AccessKey", Encoding.UTF8);
            } else {
                return "";
            }
        }

        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString().ToLower();
        }

        public static int GetRandomPort()
        {
            Random random = new Random();

            return random.Next(50000, 70000);
        }

        public static string GetGameServerScript(int placeId, int gamePort, string baseUrl)
        {
            string gameServerScript = "";
            using (StreamReader sr = new StreamReader(File.Open(GetCurrentWorkingDirectory() + "\\RCCService\\gameserver.txt", FileMode.Open), Encoding.UTF8))
            {
                gameServerScript = sr.ReadToEnd();
                File.WriteAllText(GetCurrentWorkingDirectory() + "\\Test4.txt", gameServerScript);
            }

            gameServerScript = gameServerScript.Replace("PLACEIDHERE", placeId.ToString());
            gameServerScript = gameServerScript.Replace("PORTHERE", gamePort.ToString());
            gameServerScript = gameServerScript.Replace("BASEURLHERE", "\"" + baseUrl + "\"");
            gameServerScript = gameServerScript.Replace("ACCESSKEYHERE", "\"" + GetAccessKey() + "\"");

            return gameServerScript;
        }

        public static string BuildURL(int type = 0, string baseUrl = "roblox.com")
        {
            switch(type)
            {
                case 0:
                    return "http://www." + baseUrl + "/";
                case 1:
                    return "http://api." + baseUrl + "/";
                case 2:
                    return "http://gameserver.api." + baseUrl + "/";
                default:
                    return "http://www." + baseUrl + "/";
            }
        }
    }
}
