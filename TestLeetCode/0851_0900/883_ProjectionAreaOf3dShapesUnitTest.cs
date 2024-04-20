using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _883_ProjectionAreaOf3dShapesUnitTest
    {
        _883_ProjectionAreaOf3dShapesAlg alg = new _883_ProjectionAreaOf3dShapesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 2], [3, 4]];
            int exp = 17;
            int res = alg.ProjectionArea(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[2]];
            int exp = 5;
            int res = alg.ProjectionArea(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 0], [0, 2]];
            int exp = 8;
            int res = alg.ProjectionArea(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
