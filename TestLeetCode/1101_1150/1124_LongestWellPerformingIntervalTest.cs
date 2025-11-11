using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1124_LongestWellPerformingIntervalTest
    {
        _1124_LongestWellPerformingIntervalAlg alg = new _1124_LongestWellPerformingIntervalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] hours = [9, 9, 6, 0, 6, 6, 9];
            int exp = 3;
            int res = alg.LongestWPI(hours);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] hours = [6, 6, 6];
            int exp = 0;
            int res = alg.LongestWPI(hours);
            Assert.AreEqual(exp, res);
        }
    }
}
