using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1901_1950
{
    [TestClass]
    public class _1928_MinimumCostToReachDestinationInTimeTest
    {
        _1928_MinimumCostToReachDestinationInTimeAlg alg = new _1928_MinimumCostToReachDestinationInTimeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int maxTime = 30;
            int[][] edges = [[0, 1, 10], [1, 2, 10], [2, 5, 10], [0, 3, 1], [3, 4, 10], [4, 5, 15]];
            int[] passingFees = [5, 1, 2, 20, 20, 3];
            int exp = 11;
            int res = alg.MinCost(maxTime, edges, passingFees);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int maxTime = 29;
            int[][] edges = [[0, 1, 10], [1, 2, 10], [2, 5, 10], [0, 3, 1], [3, 4, 10], [4, 5, 15]];
            int[] passingFees = [5, 1, 2, 20, 20, 3];
            int exp = 48;
            int res = alg.MinCost(maxTime, edges, passingFees);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int maxTime = 25;
            int[][] edges = [[0, 1, 10], [1, 2, 10], [2, 5, 10], [0, 3, 1], [3, 4, 10], [4, 5, 15]];
            int[] passingFees = [5, 1, 2, 20, 20, 3];
            int exp = -1;
            int res = alg.MinCost(maxTime, edges, passingFees);
            Assert.AreEqual(exp, res);
        }
    }
}
