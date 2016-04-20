﻿using System;
using System.Configuration;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virus_Total_Never_Analyzed;
using Virus_Total_Never_Analyzed.Exceptions;
using Virus_Total_Never_Analyzed.Objects;


namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class FileScanTests
    {
        private static VirusTotals _virusTotal;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _virusTotal = new VirusTotals("501caf66349cc7357eb4398ac3298fdd03dec01a3e2f3ad576525aa7b57a1987");
        }

        [TestMethod]
        public void ScanKnownFile()
        {
            //Create the EICAR test virus. See http://www.eicar.org/86-0-Intended-use.html
            FileInfo fileInfo = new FileInfo("EICAR.txt");
            File.WriteAllText(fileInfo.FullName, @"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");

            ScanResult fileResult = _virusTotal.ScanFile(fileInfo);

            //It should always be in the VirusTotal database.
            Assert.AreEqual(ScanResponseCode.Queued, fileResult.ResponseCode);
        }

        [TestMethod]
        public void ScanMultipleKnownFile()
        {
            //TODO
        }

        [TestMethod]
        public void ScanUnknownFile()
        {
            string guid = "VirusTotal.NET" + Guid.NewGuid();

            FileInfo fileInfo = new FileInfo("VirusTotal.NET-Test.txt");
            File.WriteAllText(fileInfo.FullName, guid);

            ScanResult fileResult = _virusTotal.ScanFile(fileInfo);

            //It should never be in the VirusTotal database.
            Assert.AreEqual(ScanResponseCode.Queued, fileResult.ResponseCode);
        }

        [TestMethod]
        public void ScanMultipleUnknownFile()
        {
            //TODO
        }

        [TestMethod]
        public void ScanSmallFile()
        {
            ScanResult fileResult = _virusTotal.ScanFile(new byte[1], "VirusTotal.NET-Test.txt");

            //It has been scanned before, we expect it to return queued.
            Assert.AreEqual(ScanResponseCode.Queued, fileResult.ResponseCode);
        }

        [TestMethod]
        [ExpectedException(typeof(SizeLimitException))]
        public void ScanLargeFile()
        {
            //We expect it to throw a SizeLimitException because the file is above the legal limit
            _virusTotal.ScanFile(new byte[_virusTotal.FileSizeLimit + 1], "VirusTotal.NET-Test.txt");
        }

        [TestMethod]
        public void ScanLargeFile2()
        {
            _virusTotal.Timeout = 1000 * 250;
            _virusTotal.ScanFile(new byte[_virusTotal.FileSizeLimit], "VirusTotal.NET-Test.txt");
        }
    }
}
