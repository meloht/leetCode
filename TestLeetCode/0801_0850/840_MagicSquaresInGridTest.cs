using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _840_MagicSquaresInGridTest
    {
        _840_MagicSquaresInGridAlg alg = new _840_MagicSquaresInGridAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [
                [4, 3, 8, 4], 
                [9, 5, 1, 9], 
                [2, 7, 6, 2]];
            int exp = 1;
            int res = alg.NumMagicSquaresInside(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[8]];
            int exp = 0;
            int res = alg.NumMagicSquaresInside(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[5, 5, 5], [5, 5, 5], [5, 5, 5]];
            int exp = 0;
            int res = alg.NumMagicSquaresInside(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] grid = [
                [3, 10, 2, 3, 4], 
                [4, 5, 6, 8, 1], 
                [8, 8, 1, 6, 8], 
                [1, 3, 5, 7, 1], 
                [9, 4, 9, 2, 9]];
            int exp = 1;
            int res = alg.NumMagicSquaresInside(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
