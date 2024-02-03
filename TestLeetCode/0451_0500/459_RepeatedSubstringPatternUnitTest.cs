using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _459_RepeatedSubstringPatternUnitTest
    {
        _459_RepeatedSubstringPatternAlg alg = new _459_RepeatedSubstringPatternAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abab";
            bool exp = true;
            var res = alg.RepeatedSubstringPattern(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aba";
            bool exp = false;
            var res = alg.RepeatedSubstringPattern(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcabcabcabc";
            bool exp = true;
            var res = alg.RepeatedSubstringPattern(s);
            Assert.AreEqual(exp, res);
        }
    }
}
