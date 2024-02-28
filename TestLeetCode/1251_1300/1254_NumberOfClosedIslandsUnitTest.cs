using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1251_1300
{
    [TestClass]
    public class _1254_NumberOfClosedIslandsUnitTest
    {
        _1254_NumberOfClosedIslandsAlg alg = new _1254_NumberOfClosedIslandsAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 1, 1, 1, 1, 1, 1, 0], [1, 0, 0, 0, 0, 1, 1, 0], [1, 0, 1, 0, 1, 1, 1, 0], [1, 0, 0, 0, 0, 1, 0, 1], [1, 1, 1, 1, 1, 1, 1, 0]];
            int exp = 2;
            int res = alg.ClosedIsland(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 0, 1, 0, 0], [0, 1, 0, 1, 0], [0, 1, 1, 1, 0]];
            int exp = 1;
            int res = alg.ClosedIsland(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [
             [1,1,1,1,1,1,1],
             [1,0,0,0,0,0,1],
             [1,0,1,1,1,0,1],
             [1,0,1,0,1,0,1],
             [1,0,1,1,1,0,1],
             [1,0,0,0,0,0,1],
             [1,1,1,1,1,1,1]];
            int exp = 2;
            int res = alg.ClosedIsland(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
