using leetCode._2151_2200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2151_2200
{
    [TestClass]
    public class _2187_MinimumTimeToCompleteTripsTest
    {
        _2187_MinimumTimeToCompleteTripsAlg alg = new _2187_MinimumTimeToCompleteTripsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] time = [1, 2, 3];
            int totalTrips = 5;
            long exp = 3;
            long res = alg.MinimumTime(time, totalTrips);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] time = [2];
            int totalTrips = 1;
            long exp = 2;
            long res = alg.MinimumTime(time, totalTrips);
            Assert.AreEqual(exp, res);
        }
    }
}
