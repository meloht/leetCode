using leetCode.LCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LCP
{
    [TestClass]
    public class LCP_61Test
    {
        LCP_61 alg = new LCP_61();

        [TestMethod]
        public void TestCase01()
        {
            int[] temperatureA = [21, 18, 18, 18, 31], temperatureB = [34, 32, 16, 16, 17];
            int exp = 2;
            int res = alg.TemperatureTrend(temperatureA, temperatureB);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] temperatureA = [5, 10, 16, -6, 15, 11, 3], temperatureB = [16, 22, 23, 23, 25, 3, -16];
            int exp = 3;
            int res = alg.TemperatureTrend(temperatureA, temperatureB);
            Assert.AreEqual(exp, res);
        }
    }
}
