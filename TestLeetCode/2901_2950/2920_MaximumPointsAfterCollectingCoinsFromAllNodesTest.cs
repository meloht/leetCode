using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2920_MaximumPointsAfterCollectingCoinsFromAllNodesTest
    {
        _2920_MaximumPointsAfterCollectingCoinsFromAllNodesAlg alg = new _2920_MaximumPointsAfterCollectingCoinsFromAllNodesAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[][] edges = [[0, 1], [1, 2], [2, 3]];
            int[] coins = [10, 10, 3, 3];
            int k = 5;
            int exp = 11;
            int res = alg.MaximumPoints(edges, coins, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] edges = [[0, 1], [0, 2]];
            int[] coins = [8, 4, 4];
            int k = 0;
            int exp = 16;
            int res = alg.MaximumPoints(edges, coins, k);
            Assert.AreEqual(exp, res);
        }

    }
}
