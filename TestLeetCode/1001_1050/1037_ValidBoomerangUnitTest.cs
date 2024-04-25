using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1037_ValidBoomerangUnitTest
    {
        _1037_ValidBoomerangAlg alg = new _1037_ValidBoomerangAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[1, 1], [2, 3], [3, 2]];
            bool exp = true;
            bool res = alg.IsBoomerang(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 1], [2, 2], [3, 3]];
            bool exp = false;
            bool res = alg.IsBoomerang(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[0, 0], [1, 0], [2, 2]];
            bool exp = true;
            bool res = alg.IsBoomerang(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] points = [[1, 1], [2, 2], [7, 7]];
            bool exp = false;
            bool res = alg.IsBoomerang(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] points = [[0, 1], [2, 1], [0, 0]];
            bool exp = true;
            bool res = alg.IsBoomerang(points);
            Assert.AreEqual(exp, res);
        }
    }
}
