using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _647_PalindromicSubstringsUnitTest
    {
        _647_PalindromicSubstringsAlg alg = new _647_PalindromicSubstringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abc";
            int exp = 3;
            int res = alg.CountSubstrings(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aaa";
            int exp = 6;
            int res = alg.CountSubstrings(s);
            Assert.AreEqual(exp, res);
        }
    }
}
