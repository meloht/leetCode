using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3235_CheckIfTheRectangleCornerIsReachableTest
    {
        _3235_CheckIfTheRectangleCornerIsReachableAlg alg = new _3235_CheckIfTheRectangleCornerIsReachableAlg();

        [TestMethod]
        public void TestCase01()
        {
            int X = 3, Y = 4;
            int[][] circles = [[2, 1, 1]];
            bool exp = true;
            bool res = alg.CanReachCorner(X,Y,circles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int X = 3, Y = 3;
            int[][] circles = [[1, 1, 2]];
            bool exp = false;
            bool res = alg.CanReachCorner(X, Y, circles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int X = 4, Y = 4;
            int[][] circles = [[5, 5, 1]];
            bool exp = true;
            bool res = alg.CanReachCorner(X, Y, circles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int X = 4, Y = 4;
            int[][] circles = [[5, 5, 1]];
            bool exp = true;
            bool res = alg.CanReachCorner(X, Y, circles);
            Assert.AreEqual(exp, res);
        }
    }
}
