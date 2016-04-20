using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virus_Total_Never_Analyzed;
using Virus_Total_Never_Analyzed.Objects;



namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class DomainReportTests
    {
        private static VirusTotals _virusTotal;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _virusTotal = new VirusTotals("501caf66349cc7357eb4398ac3298fdd03dec01a3e2f3ad576525aa7b57a1987");
        }

        [TestMethod]
        public void GetDomainReportKnownDomain()
        {
            DomainReport report = _virusTotal.GetDomainReport("google.com");
            Assert.AreEqual(ReportResponseCode.Present, report.ResponseCode);
        }

        [TestMethod]
        public void GetDomainReportUnknownDomain()
        {
            DomainReport report = _virusTotal.GetDomainReport(Guid.NewGuid() + ".com");
            Assert.AreEqual(ReportResponseCode.NotPresent, report.ResponseCode);
        }

        [TestMethod]
        public void GetDomainReportInvalidDomain()
        {
            //This test should pass, but VT have added "." as a domain, which should not happen.
            //It therefore fails, which is to be expcted until VT team fixes this bug.
            DomainReport report = _virusTotal.GetDomainReport(".");
            Assert.AreEqual(ReportResponseCode.Error, report.ResponseCode);
        }
    }
}
