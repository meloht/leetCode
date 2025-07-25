using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1034_ColoringABorderTest
    {
        _1034_ColoringABorderAlg alg = new _1034_ColoringABorderAlg();
        [TestMethod]
        public void Test01()
        {
            int[][] grid = [
                [1, 1], 
                [1, 2]];
            int row = 0, col = 0, color = 3;
            int[][] exp = [
                [3, 3], 
                [3, 2]];
            int[][] res = alg.ColorBorder(grid, row, col, color);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void Test02()
        {
            int[][] grid = [
                [1, 2, 2], 
                [2, 3, 2]];
            int row = 0, col = 1, color = 3;
            int[][] exp = [
                [1, 3, 3], 
                [2, 3, 3]];
            int[][] res = alg.ColorBorder(grid, row, col, color);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void Test03()
        {
            int[][] grid = [
                [1, 1, 1], 
                [1, 1, 1], 
                [1, 1, 1]];
            int row = 1, col = 1, color = 2;
            int[][] exp = [
                [2, 2, 2], 
                [2, 1, 2], 
                [2, 2, 2]];
            int[][] res = alg.ColorBorder(grid, row, col, color);
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
