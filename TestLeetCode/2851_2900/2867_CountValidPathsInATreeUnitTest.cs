using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2851_2900
{
    [TestClass]
    public class _2867_CountValidPathsInATreeUnitTest
    {
        _2867_CountValidPathsInATreeAlg alg = new _2867_CountValidPathsInATreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int[][] edges = [[1, 2], [1, 3], [2, 4], [2, 5]];
            long exp = 4;
            long res = alg.CountPaths(n, edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6;
            int[][] edges = [[1, 2], [1, 3], [2, 4], [3, 5], [3, 6]];
            long exp = 6;
            long res = alg.CountPaths(n, edges);
            Assert.AreEqual(exp, res);
        }
    }
}
