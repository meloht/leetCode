using leetCode._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2301_2350
{
    [TestClass]
    public class _2322_MinimumScoreAfterRemovalsOnATreeTest
    {
        _2322_MinimumScoreAfterRemovalsOnATreeAlg alg = new _2322_MinimumScoreAfterRemovalsOnATreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 5, 5, 4, 11];
            int[][] edges = [[0, 1], [1, 2], [1, 3], [3, 4]];
            int exp = 9;
            int res = alg.MinimumScore(nums, edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 5, 2, 4, 4, 2];
            int[][] edges = [[0, 1], [1, 2], [5, 2], [4, 3], [1, 3]];
            int exp = 0;
            int res = alg.MinimumScore(nums, edges);
            Assert.AreEqual(exp, res);
        }
    }
}
