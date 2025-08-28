using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3446_SortMatrixByDiagonalsTest
    {
        _3446_SortMatrixByDiagonalsAlg alg = new _3446_SortMatrixByDiagonalsAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] grid = [[1, 7, 3], [9, 8, 2], [4, 5, 6]];
            int[][] exp = [[8, 2, 3], [9, 6, 7], [4, 5, 1]];
            int[][] res = alg.SortMatrix(grid);

            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void Test02()
        {
            int[][] grid = [[0, 1], [1, 2]];
            int[][] exp = [[2, 1], [1, 0]];
            int[][] res = alg.SortMatrix(grid);

            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void Test03()
        {
            int[][] grid = [[1]];
            int[][] exp = [[1]];
            int[][] res = alg.SortMatrix(grid);

            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
