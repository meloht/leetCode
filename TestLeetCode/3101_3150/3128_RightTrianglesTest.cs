using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3128_RightTrianglesTest
    {
        _3128_RightTrianglesAlg alg = new _3128_RightTrianglesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1, 0], [0, 1, 1], [0, 1, 0]];
            long exp = 2;
            long res=alg.NumberOfRightTriangles(grid);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 0, 0, 0], [0, 1, 0, 1], [1, 0, 0, 0]];
            long exp = 0;
            long res = alg.NumberOfRightTriangles(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 0, 1], [1, 0, 0], [1, 0, 0]];
            long exp = 2;
            long res = alg.NumberOfRightTriangles(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
