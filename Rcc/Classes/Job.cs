namespace GameServer.Rcc
{
    class Job
    {
        public string id;
        public double expirationInSeconds;
        public int category;
        public double cores;

        public Job(string id, double expirationInSeconds = 10, int category = 0, double cores = 0)
        {
            this.id = id;
            this.expirationInSeconds = expirationInSeconds;
            this.category = category;
            this.cores = cores;
        }
    }
}