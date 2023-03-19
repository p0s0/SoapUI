using System;

namespace GameServer
{
    class Utility
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString().ToLower();
        }
    }
}
