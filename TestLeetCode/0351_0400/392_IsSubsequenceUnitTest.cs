using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _392_IsSubsequenceUnitTest
    {
        _392_IsSubsequenceAlg alg = new _392_IsSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abc", t = "ahbgdc";
            bool exp = true;
            bool res = alg.IsSubsequence(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "axc", t = "ahbgdc";
            bool exp = false;
            bool res = alg.IsSubsequence(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aaaaaa", t = "bbaaaa";
            bool exp = false;
            bool res = alg.IsSubsequence(s, t);
            Assert.AreEqual(exp, res);
        }
    }
}
