using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1523_CountOddNumbersInAnIntervalRangeUnitTest
    {
        _1523_CountOddNumbersInAnIntervalRangeAlg alg = new _1523_CountOddNumbersInAnIntervalRangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int low = 3, high = 7;
            int exp = 3;
            int res = alg.CountOdds(low, high);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int low = 8, high = 10;
            int exp = 1;
            int res = alg.CountOdds(low, high);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase023()
        {
            int low = 1, high = 8;
            int exp = 4;
            int res = alg.CountOdds(low, high);
            Assert.AreEqual(exp, res);
        }
    }
}
