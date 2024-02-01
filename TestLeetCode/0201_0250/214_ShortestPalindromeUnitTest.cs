using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _214_ShortestPalindromeUnitTest
    {
        _214_ShortestPalindromeAlg alg = new _214_ShortestPalindromeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aacecaaa";
            string exp = "aaacecaaa";
            string res = alg.ShortestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcd";
            string exp = "dcbabcd";
            string res = alg.ShortestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abb";
            string exp = "bbabb";
            string res = alg.ShortestPalindrome(s);
            Assert.AreEqual(exp, res);
        }
    }
}
