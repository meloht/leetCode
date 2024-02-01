using leetCode._2451_2500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2451_2500
{
    [TestClass]
    public class _2469_ConvertTheTemperatureUnitTest
    {
        _2469_ConvertTheTemperatureAlg alg = new _2469_ConvertTheTemperatureAlg();

        [TestMethod]
        public void TestCase01()
        {
            double celsius = 36.50;
            double[] exp = [309.65000, 97.70000];
            double[] res = alg.ConvertTemperature(celsius);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            double celsius = 122.11;
            double[] exp = [395.26000, 251.79800];
            double[] res = alg.ConvertTemperature(celsius);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
