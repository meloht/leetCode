using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3111_MinimumRectanglesToCoverPointsTest
    {
        _3111_MinimumRectanglesToCoverPointsAlg alg = new _3111_MinimumRectanglesToCoverPointsAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[2, 1], [1, 0], [1, 4], [1, 8], [3, 5], [4, 6]]; 
            int w = 1;
            int exp = 2;
            int res = alg.MinRectanglesToCoverPoints(points, w);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[0, 0], [1, 1], [2, 2], [3, 3], [4, 4], [5, 5], [6, 6]];
            int w = 2;
            int exp = 3;
            int res = alg.MinRectanglesToCoverPoints(points, w);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[2, 3], [1, 2]];
            int w = 0;
            int exp = 2;
            int res = alg.MinRectanglesToCoverPoints(points, w);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] points = [[1, 3], [7, 3]];
            int w = 1;
            int exp = 2;
            int res = alg.MinRectanglesToCoverPoints(points, w);
            Assert.AreEqual(exp, res);
        }
    }
}
