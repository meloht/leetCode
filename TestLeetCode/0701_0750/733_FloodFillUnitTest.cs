using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _733_FloodFillUnitTest
    {
        _733_FloodFillAlg alg = new _733_FloodFillAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] image = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
            int sr = 1, sc = 1, newColor = 2;
            int[][] exp = [[2, 2, 2], [2, 2, 0], [2, 0, 1]];
            int[][] res = alg.FloodFill(image, sr, sc, newColor);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] image = [[0, 0, 0], [0, 0, 0]];
            int sr = 0, sc = 0, newColor = 2;
            int[][] exp = [[2, 2, 2], [2, 2, 2]];
            int[][] res = alg.FloodFill(image, sr, sc, newColor);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
