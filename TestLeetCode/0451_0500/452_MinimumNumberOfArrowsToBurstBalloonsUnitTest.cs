using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _452_MinimumNumberOfArrowsToBurstBalloonsUnitTest
    {
        _452_MinimumNumberOfArrowsToBurstBalloonsAlg alg = new _452_MinimumNumberOfArrowsToBurstBalloonsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[10, 16], [2, 8], [1, 6], [7, 12]];
            int exp = 2;
            int res = alg.FindMinArrowShots(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 2], [3, 4], [5, 6], [7, 8]];
            int exp = 4;
            int res = alg.FindMinArrowShots(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] points = [[1, 2], [2, 3], [3, 4], [4, 5]];
            int exp = 2;
            int res = alg.FindMinArrowShots(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] points = [[3, 9], [7, 12], [3, 8], [6, 8], [9, 10], [2, 9], [0, 9], [3, 9], [0, 6], [2, 8]];
            int exp = 2;
            int res = alg.FindMinArrowShots(points);
            Assert.AreEqual(exp, res);
        }
    }
}
