using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virus_Total_Never_Analyzed;
using Virus_Total_Never_Analyzed.Objects;

namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class IPReportTests
    {
        private static VirusTotals _virusTotal;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _virusTotal = new VirusTotals("501caf66349cc7357eb4398ac3298fdd03dec01a3e2f3ad576525aa7b57a1987");
        }

        [TestMethod]
        public void GetIPReportKnownIP()
        {
            IPReport report = _virusTotal.GetIPReport("8.8.8.8"); //Google DNS
            Assert.AreEqual(IPReportResponseCode.Present, report.ResponseCode);
        }
    }
}
