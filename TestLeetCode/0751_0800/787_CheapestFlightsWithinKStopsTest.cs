using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _787_CheapestFlightsWithinKStopsTest
    {
        _787_CheapestFlightsWithinKStopsAlg alg = new _787_CheapestFlightsWithinKStopsAlg();
        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int[][] flights = [
                [0, 1, 100],
                [1, 2, 100],
                [2, 0, 100],
                [1, 3, 600],
                [2, 3, 200]];
            int src = 0;
            int dst = 3;
            int k = 1;
            int exp = 700;
            int res = alg.FindCheapestPrice(n, flights, src, dst, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int[][] flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]];
            int src = 0;
            int dst = 2;
            int k = 1;
            int exp = 200;
            int res = alg.FindCheapestPrice(n, flights, src, dst, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3;
            int[][] flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]];
            int src = 0;
            int dst = 2;
            int k = 0;
            int exp = 500;
            int res = alg.FindCheapestPrice(n, flights, src, dst, k);
            Assert.AreEqual(exp, res);
        }
    }
}
