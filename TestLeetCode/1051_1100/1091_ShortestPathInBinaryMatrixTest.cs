using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1091_ShortestPathInBinaryMatrixTest
    {
        _1091_ShortestPathInBinaryMatrixAlg alg = new _1091_ShortestPathInBinaryMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1], [1, 0]];
            int exp = 2;
            int res = alg.ShortestPathBinaryMatrix(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 0, 0], [1, 1, 0], [1, 1, 0]];
            int exp = 4;
            int res = alg.ShortestPathBinaryMatrix(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 0, 0], [1, 1, 0], [1, 1, 0]];
            int exp = -1;
            int res = alg.ShortestPathBinaryMatrix(grid);
            Assert.AreEqual(exp, res);
        }

    }
}
