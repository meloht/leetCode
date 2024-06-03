using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _391_PerfectRectangleUnitTest
    {
        _391_PerfectRectangleAlg alg = new _391_PerfectRectangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] rectangles = [[1, 1, 3, 3], [3, 1, 4, 2], [3, 2, 4, 4], [1, 3, 2, 4], [2, 3, 3, 4]];
            bool exp = true;
            bool res = alg.IsRectangleCover(rectangles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] rectangles = [[1, 1, 2, 3], [1, 3, 2, 4], [3, 1, 4, 2], [3, 2, 4, 4]];
            bool exp = false;
            bool res = alg.IsRectangleCover(rectangles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] rectangles = [[1, 1, 3, 3], [3, 1, 4, 2], [1, 3, 2, 4], [2, 2, 4, 4]];
            bool exp = false;
            bool res = alg.IsRectangleCover(rectangles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] rectangles = [[0, 0, 1, 1], [0, 1, 3, 2], [1, 0, 2, 2]];
            bool exp = false;
            bool res = alg.IsRectangleCover(rectangles);
            Assert.AreEqual(exp, res);
        }
    }
}
