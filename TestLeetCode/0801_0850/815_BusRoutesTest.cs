using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _815_BusRoutesTest
    {
        _815_BusRoutesAlg alg = new _815_BusRoutesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] routes = [[1, 2, 7], [3, 6, 7]];
            int source = 1, target = 6;
            int exp = 2;
            int res = alg.NumBusesToDestination(routes, source, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] routes = [[7, 12], [4, 5, 15], [6], [15, 19], [9, 12, 13]];
            int source = 15, target = 12;
            int exp = -1;
            int res = alg.NumBusesToDestination(routes, source, target);
            Assert.AreEqual(exp, res);
        }
    }
}
