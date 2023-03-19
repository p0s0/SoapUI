using System;
using System.Diagnostics;
using System.IO;
using System.Text;

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
