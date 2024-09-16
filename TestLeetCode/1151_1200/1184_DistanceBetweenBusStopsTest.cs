using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1184_DistanceBetweenBusStopsTest
    {
        _1184_DistanceBetweenBusStopsAlg alg = new _1184_DistanceBetweenBusStopsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] distance = [1, 2, 3, 4];
            int start = 0, destination = 1;
            int exp = 1;
            int res = alg.DistanceBetweenBusStops(distance, start, destination);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] distance = [1, 2, 3, 4];
            int start = 0, destination = 2;
            int exp = 3;
            int res = alg.DistanceBetweenBusStops(distance, start, destination);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] distance = [1, 2, 3, 4];
            int start = 0, destination = 3;
            int exp = 4;
            int res = alg.DistanceBetweenBusStops(distance, start, destination);
            Assert.AreEqual(exp, res);

        }
    }
}
