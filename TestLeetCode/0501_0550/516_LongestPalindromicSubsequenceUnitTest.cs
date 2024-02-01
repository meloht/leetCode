using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _516_LongestPalindromicSubsequenceUnitTest
    {
        _516_LongestPalindromicSubsequenceAlg alg = new _516_LongestPalindromicSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "bbbab";
            int exp = 4;
            int res = alg.LongestPalindromeSubseq(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cbbd";
            int exp = 2;
            int res = alg.LongestPalindromeSubseq(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "cbbdc";
            int exp = 4;
            int res = alg.LongestPalindromeSubseq(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "abcdfgecba";
            int exp = 7;
            int res = alg.LongestPalindromeSubseq(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            string s = "bbbabcdefghiltyzqlihgfedc";
            int exp = 17;
            int res = alg.LongestPalindromeSubseq(s);
            Assert.AreEqual(exp, res);
        }
    }
}
