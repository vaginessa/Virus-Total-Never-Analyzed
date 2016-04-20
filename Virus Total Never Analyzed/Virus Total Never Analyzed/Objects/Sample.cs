using System;

namespace Virus_Total_Never_Analyzed.Objects
{
    public class Sample
    {
        public DateTime Date { get; set; }
        public int Positives { get; set; }
        public int Total { get; set; }
        public string Sha256 { get; set; }
    }
}