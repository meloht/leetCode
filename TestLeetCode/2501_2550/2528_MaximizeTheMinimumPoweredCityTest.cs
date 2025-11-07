using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2528_MaximizeTheMinimumPoweredCityTest
    {
        _2528_MaximizeTheMinimumPoweredCityAlg alg = new _2528_MaximizeTheMinimumPoweredCityAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            int[] stations = [1, 2, 4, 5, 0];
            int r = 1, k = 2;
            long exp = 5;
            long res = alg.MaxPower(stations, r, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] stations = [4, 4, 4, 4];
            int r = 0, k = 3;
            long exp = 4;
            long res = alg.MaxPower(stations, r, k);
            Assert.AreEqual(exp, res);
        }
    }
}
