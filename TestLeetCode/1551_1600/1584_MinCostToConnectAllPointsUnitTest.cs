using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1584_MinCostToConnectAllPointsUnitTest
    {
        _1584_MinCostToConnectAllPointsAlg alg = new _1584_MinCostToConnectAllPointsAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]];
            int exp = 20;
            int res = alg.MinCostConnectPoints(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[3, 12], [-2, 5], [-4, 1]];
            int exp = 18;
            int res = alg.MinCostConnectPoints(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[0, 0], [1, 1], [1, 0], [-1, 1]];
            int exp = 4;
            int res = alg.MinCostConnectPoints(points);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[][] points = [[-1000000, -1000000], [1000000, 1000000]];
            int exp = 4000000;
            int res = alg.MinCostConnectPoints(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] points = [[0, 0]];
            int exp = 0;
            int res = alg.MinCostConnectPoints(points);
            Assert.AreEqual(exp, res);
        }
    }
}
