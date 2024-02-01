using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0994_RottingOrangesUnitTest
    {
        _0994_RottingOrangesAlg alg = new _0994_RottingOrangesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
            int exp = 4;
            int res = alg.OrangesRotting(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];
            int exp = -1;
            int res = alg.OrangesRotting(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[0, 2]];
            int exp = 0;
            int res = alg.OrangesRotting(grid);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[][] grid = [[1], [2]];
            int exp = 1;
            int res = alg.OrangesRotting(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] grid = [[2, 2], [1, 1], [0, 0], [2, 0]];
            int exp = 1;
            int res = alg.OrangesRotting(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
