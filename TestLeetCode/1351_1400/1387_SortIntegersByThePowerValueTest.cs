using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1387_SortIntegersByThePowerValueTest
    {
        _1387_SortIntegersByThePowerValueAlg alg = new _1387_SortIntegersByThePowerValueAlg();

        [TestMethod]
        public void TestCase01()
        {
            int lo = 12, hi = 15, k = 2;
            int exp = 13;
            int res = alg.GetKth(lo,hi,k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int lo = 7, hi = 11, k = 4;
            int exp = 7;
            int res = alg.GetKth(lo, hi, k);
            Assert.AreEqual(exp, res);
        }

        
    }
}
