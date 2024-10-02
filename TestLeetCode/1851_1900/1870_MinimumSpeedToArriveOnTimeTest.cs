using leetCode._1851_1900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1851_1900
{
    [TestClass]
    public class _1870_MinimumSpeedToArriveOnTimeTest
    {
        _1870_MinimumSpeedToArriveOnTimeAlg alg = new _1870_MinimumSpeedToArriveOnTimeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] dist = [1, 3, 2];
            double hour = 6;
            int exp = 1;
            int res = alg.MinSpeedOnTime(dist, hour);
            Assert.AreEqual(exp, hour);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] dist = [1, 3, 2];
            double hour = 2.7;
            int exp = alg.MinSpeedOnTime(dist, hour);
            Assert.AreEqual(exp, hour);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] dist = [1, 3, 2];
            double hour = 1.9;
            int exp = -1;
            int res = alg.MinSpeedOnTime(dist, hour);
            Assert.AreEqual(exp, hour);
        }
    }
}
