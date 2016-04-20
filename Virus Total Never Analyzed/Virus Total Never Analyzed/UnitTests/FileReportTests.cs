using System;
using System.Configuration;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virus_Total_Never_Analyzed;
using Virus_Total_Never_Analyzed.Exceptions;
using Virus_Total_Never_Analyzed.Objects;


namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class FileReportTests
    {
        private static VirusTotals _virusTotal;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _virusTotal = new VirusTotals(null);
        }

        [TestMethod]
        public void GetReportForKnownFile()
        {
            //Create a hash of the EICAR test virus. See http://www.eicar.org/86-0-Intended-use.html
            string hash = HashHelper.GetMD5(@"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");

            FileReport fileReport = _virusTotal.GetFileReport(hash);

            //It should always be in the VirusTotal database.
            Assert.AreEqual(ReportResponseCode.Present, fileReport.ResponseCode);
        }

        [TestMethod]
        public void GetMultipleReportForKnownFile()
        {
            //TODO
        }

        [TestMethod]
        public void GetReportForUnknownFile()
        {
            string guid = "VirusTotal.NET" + Guid.NewGuid();

            FileInfo fileInfo = new FileInfo("VirusTotal.NET-Test.txt");
            File.WriteAllText(fileInfo.FullName, guid);

            FileReport fileReport = _virusTotal.GetFileReport(fileInfo);

            //It should not be in the VirusTotal database already, which means it should return error.
            Assert.AreEqual(ReportResponseCode.NotPresent, fileReport.ResponseCode);
        }

        [TestMethod]
        public void GetMultipleReportForUnknownFile()
        {
            //TODO
        }

        [TestMethod]
        public void GetReportForRecentFile()
        {
            //We create an unknown file
            string guid = "VirusTotal.NET" + Guid.NewGuid();

            FileInfo fileInfo = new FileInfo("VirusTotal.NET-Test.txt");
            File.WriteAllText(fileInfo.FullName, guid);

            //Attempt to submit it for scan
            ScanResult result = _virusTotal.ScanFile(fileInfo);

            FileReport fileReport = _virusTotal.GetFileReport(result.ScanId);

            //It should not be in the VirusTotal database already, which means it should return error.
            Assert.AreEqual(ReportResponseCode.StillQueued, fileReport.ResponseCode);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidResourceException))]
        public void GetReportForInvalidResource()
        {
            FileReport fileReport = _virusTotal.GetFileReport("aaaaaaaaaaa");
        }
    }
}