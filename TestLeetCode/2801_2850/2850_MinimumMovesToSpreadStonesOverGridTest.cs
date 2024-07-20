using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2850_MinimumMovesToSpreadStonesOverGridTest
    {
        _2850_MinimumMovesToSpreadStonesOverGridAlg alg = new _2850_MinimumMovesToSpreadStonesOverGridAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 1, 0], [1, 1, 1], [1, 2, 1]];
            int exp = 3;
            int res = alg.MinimumMoves(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 3, 0], [1, 0, 0], [1, 0, 3]];
            int exp = 4;
            int res = alg.MinimumMoves(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
