using System.Diagnostics;

namespace GameServer.Rcc.Classes
{
    class RCCGameServer
    {
        public Process gameProcess;
        public int gamePort;
        public int placeId;
        public int servicePort;
        public string jobId;

        public RCCGameServer(Process gameProcess, int gamePort, int placeId, int servicePort, string jobId)
        {
            this.gameProcess = gameProcess;
            this.gamePort = gamePort;
            this.placeId = placeId;
            this.servicePort = servicePort;
            this.jobId = jobId;
        }
    }
}
