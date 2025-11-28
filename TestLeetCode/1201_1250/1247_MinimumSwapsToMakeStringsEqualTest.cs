using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1247_MinimumSwapsToMakeStringsEqualTest
    {
        _1247_MinimumSwapsToMakeStringsEqualAlg alg = new _1247_MinimumSwapsToMakeStringsEqualAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "xx", s2 = "yy";
            int exp = 1;
            int res = alg.MinimumSwap(s1, s2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "xy", s2 = "yx";
            int exp = 2;
            int res = alg.MinimumSwap(s1, s2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "xx", s2 = "xy";
            int exp = -1;
            int res = alg.MinimumSwap(s1, s2);
            Assert.AreEqual(exp, res);
        }
    }
}
