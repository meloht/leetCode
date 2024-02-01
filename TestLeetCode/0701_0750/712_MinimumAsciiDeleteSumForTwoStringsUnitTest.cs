using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _712_MinimumAsciiDeleteSumForTwoStringsUnitTest
    {
        _712_MinimumAsciiDeleteSumForTwoStringsAlg alg = new _712_MinimumAsciiDeleteSumForTwoStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "sea", s2 = "eat";
            int exp = 231;
            int res = alg.MinimumDeleteSum(s1, s2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "delete", s2 = "leet";
            int exp = 403;
            int res = alg.MinimumDeleteSum(s1, s2);
            Assert.AreEqual(exp, res);
        }
    }
}
