using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _467_UniqueSubstringsInWraparoundStringTest
    {
        _467_UniqueSubstringsInWraparoundStringAlg alg = new _467_UniqueSubstringsInWraparoundStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "a";
            int exp = 1;
            int res = alg.FindSubstringInWraproundString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cac";
            int exp = 2;
            int res = alg.FindSubstringInWraproundString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "zab";
            int exp = 6;
            int res = alg.FindSubstringInWraproundString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
