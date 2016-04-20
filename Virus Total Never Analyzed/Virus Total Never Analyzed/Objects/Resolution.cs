using System;

namespace Virus_Total_Never_Analyzed.Objects
{
    public class Resolution
    {
        public DateTime LastResolved { get; set; }

        public string Hostname { get; set; }

        public string IPAddress { get; set; }
    }
}
