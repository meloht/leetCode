using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _463_IslandPerimeterUnitTest
    {
        _463_IslandPerimeterAlg alg = new _463_IslandPerimeterAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]];
            int exp = 16;
            int res = alg.IslandPerimeter(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1]];
            int exp = 4;
            int res = alg.IslandPerimeter(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 0]];
            int exp = 4;
            int res = alg.IslandPerimeter(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
