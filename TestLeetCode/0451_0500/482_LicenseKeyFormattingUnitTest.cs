using leetCode._0451_0500;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _482_LicenseKeyFormattingUnitTest
    {
        _482_LicenseKeyFormattingAlg alg = new _482_LicenseKeyFormattingAlg();
        [TestMethod]
        public void TestCase01()
        {
            string S = "5F3Z-2e-9-w";
            int k = 4;
            string exp = "5F3Z-2E9W";
            string res = alg.LicenseKeyFormatting(S, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string S = "2-5g-3-J";
            int k = 2;
            string exp = "2-5G-3J";
            string res = alg.LicenseKeyFormatting(S, k);
            Assert.AreEqual(exp, res);
        }
    }
}
