using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2332_TheLatestTimeToCatchABusTest
    {
        _2332_TheLatestTimeToCatchABusAlg alg = new _2332_TheLatestTimeToCatchABusAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] buses = [10, 20], passengers = [2, 17, 18, 19];
            int capacity = 2;
            int exp = 16;
            int res = alg.LatestTimeCatchTheBus(buses, passengers, capacity);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] buses = [20, 30, 10], passengers = [19, 13, 26, 4, 25, 11, 21];
            int capacity = 2;
            int exp = 20;
            int res = alg.LatestTimeCatchTheBus(buses, passengers, capacity);
            Assert.AreEqual(exp, res);
        }
    }
}
