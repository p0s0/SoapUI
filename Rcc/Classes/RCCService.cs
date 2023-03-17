using System.Diagnostics;

namespace GameServer.Rcc.Classes
{
    class RCCService
    {
        public Process serviceProcess;
        public int servicePort;
        public string jobId;

        public RCCService(Process serviceProcess, int servicePort, string jobId)
        {
            this.serviceProcess = serviceProcess;
            this.servicePort = servicePort;
            this.jobId = jobId;
        }
    }
}