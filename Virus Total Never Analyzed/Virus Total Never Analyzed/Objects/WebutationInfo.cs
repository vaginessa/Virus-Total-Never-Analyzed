using RestSharp.Deserializers;

namespace Virus_Total_Never_Analyzed.Objects
{
    public class WebutationInfo
    {
        [DeserializeAs(Name = "Adult content")]
        public string AdultContent { get; set; }

        [DeserializeAs(Name = "Safety score")]
        public int SafetyScore { get; set; }

        public string Verdict { get; set; }
    }
}