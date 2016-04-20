using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Virus_Total_Never_Analyzed
{
    [TestClass]
    public class CreateCommentTests
    {
        private static VirusTotals _virusTotal;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _virusTotal = new VirusTotals("501caf66349cc7357eb4398ac3298fdd03dec01a3e2f3ad576525aa7b57a1987");
        }

        [TestMethod]
        public void CreateValidComment()
        {
            //TODO
        }

        [TestMethod]
        public void CreateInvalidComment()
        {
            //TODO
        }
    }
}
