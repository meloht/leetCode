using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3143_MaximumPointsInsideTheSquareTest
    {
        _3143_MaximumPointsInsideTheSquareAlg alg = new _3143_MaximumPointsInsideTheSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[2, 2], [-1, -2], [-4, 4], [-3, 1], [3, -3]];
            string s = "abdca";
            int exp = 2;
            int res = alg.MaxPointsInsideSquare(points, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 1], [-2, -2], [-2, 2]];
            string s = "abb";
            int exp = 1;
            int res = alg.MaxPointsInsideSquare(points, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[1, 1], [-1, -1], [2, -2]];
            string s = "ccd";
            int exp = 0;
            int res = alg.MaxPointsInsideSquare(points, s);
            Assert.AreEqual(exp, res);
        }
    }
}
