using System;

namespace Virus_Total_Never_Analyzed.Objects
{
    public class DetectedUrl
    {
        public string Url { get; set; }

        public int Positives { get; set; }

        public int Total { get; set; }

        public DateTime ScanDate { get; set; }
    }
}
