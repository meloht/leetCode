using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1901_1950
{
    [TestClass]
    public class _1930_UniqueLength3PalindromicSubsequencesTest
    {
        _1930_UniqueLength3PalindromicSubsequencesAlg alg = new _1930_UniqueLength3PalindromicSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aabca";
            int exp = 3;
            int res = alg.CountPalindromicSubsequence(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "adc";
            int exp = 0;
            int res = alg.CountPalindromicSubsequence(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "bbcbaba";
            int exp = 4;
            int res = alg.CountPalindromicSubsequence(s);
            Assert.AreEqual(exp, res);
        }
    }
}
