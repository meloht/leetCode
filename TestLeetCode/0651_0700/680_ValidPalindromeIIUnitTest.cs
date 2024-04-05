using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _680_ValidPalindromeIIUnitTest
    {
        _680_ValidPalindromeIIAlg alg = new _680_ValidPalindromeIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aba";
            bool exp = true;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abca";
            bool exp = true;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abc";
            bool exp = false;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            string s = "deeee";
            bool exp = true;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "cbbcc";
            bool exp = true;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";
            bool exp = true;
            bool res = alg.ValidPalindrome(s);
            Assert.AreEqual(exp, res);
        }
    }
}
