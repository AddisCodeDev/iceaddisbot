using System;

namespace Iceaddis.IceaddisBot
{
    public class IceaddisEvent
    {
        public string link { get; set; }
        public Title title { get; set; }
        public DateTime date { get; set; }
    }

    public class Title
    {
        public string rendered { get; set; }
    }
}