using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _409_LongestPalindromeUnitTest
    {
        _409_LongestPalindromeAlg alg = new _409_LongestPalindromeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abccccdd";
            int exp = 7;
            int res = alg.LongestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            int exp = 1;
            int res = alg.LongestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aaaaaccc";
            int exp = 7;
            int res = alg.LongestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "AAAAAA";
            int exp = 6;
            int res = alg.LongestPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "bb";
            int exp = 2;
            int res = alg.LongestPalindrome(s);
            Assert.AreEqual(exp, res);
        }
    }
}
