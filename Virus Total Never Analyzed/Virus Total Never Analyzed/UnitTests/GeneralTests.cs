using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virus_Total_Never_Analyzed;
using Virus_Total_Never_Analyzed.Exceptions;


namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        [ExpectedException(typeof(AccessDeniedException))]
        public void UnauthorizedScan()
        {
            VirusTotals virusTotal = new VirusTotals("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); //64 characters
            virusTotal.GetFileReport("ca6d91bad9d5d5698c92dc64295a15a6"); //conficker MD5 hash
        }

        [TestMethod]
        public void GetPublicUrl()
        {
            //TODO
        }
    }
}
