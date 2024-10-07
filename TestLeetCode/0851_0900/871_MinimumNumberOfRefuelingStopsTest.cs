using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _871_MinimumNumberOfRefuelingStopsTest
    {
        _871_MinimumNumberOfRefuelingStopsAlg alg = new _871_MinimumNumberOfRefuelingStopsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int target = 1, startFuel = 1;
            int[][] stations = [];
            int exp = 0;
            int res = alg.MinRefuelStops(target, startFuel, stations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int target = 100, startFuel = 1;
            int[][] stations = [[10, 100]];
            int exp = -1;
            int res = alg.MinRefuelStops(target, startFuel, stations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int target = 100, startFuel = 10;
            int[][] stations = [[10, 60], [20, 30], [30, 30], [60, 40]];
            int exp = 2;
            int res = alg.MinRefuelStops(target, startFuel, stations);
            Assert.AreEqual(exp, res);
        }
    }
}
