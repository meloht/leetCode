using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1208_GetEqualSubstringsWithinBudgetTest
    {
        _1208_GetEqualSubstringsWithinBudgetAlg alg = new _1208_GetEqualSubstringsWithinBudgetAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcd", t = "bcdf";
            int maxCost = 3;
            int exp = 3;
            int res = alg.EqualSubstring(s, t, maxCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcd", t = "cdef";
            int maxCost = 3;
            int exp = 1;
            int res = alg.EqualSubstring(s, t, maxCost);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcd", t = "acde";
            int maxCost = 0;
            int exp = 1;
            int res = alg.EqualSubstring(s, t, maxCost);
            Assert.AreEqual(exp, res);
        }
    }
}
