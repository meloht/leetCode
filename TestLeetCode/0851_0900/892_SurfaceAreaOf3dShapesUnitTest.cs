using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _892_SurfaceAreaOf3dShapesUnitTest
    {
        _892_SurfaceAreaOf3dShapesAlg alg = new _892_SurfaceAreaOf3dShapesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 2], [3, 4]];
            int exp = 34;
            int res = alg.SurfaceArea(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
            int exp = 32;
            int res = alg.SurfaceArea(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[2, 2, 2], [2, 1, 2], [2, 2, 2]];
            int exp = 46;
            int res = alg.SurfaceArea(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
