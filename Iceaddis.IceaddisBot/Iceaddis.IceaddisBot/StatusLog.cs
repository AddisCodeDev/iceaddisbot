using System.Collections.Generic;

namespace Iceaddis.IceaddisBot
{
    public class StatusLog
    {
        public static List<string> Logs;

        public static void Log(string message)
        {
            Logs.Add(message);
        }
    }
}