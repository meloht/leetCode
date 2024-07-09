using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3102_MinimizeManhattanDistancesTest
    {
        _3102_MinimizeManhattanDistancesAlg alg = new _3102_MinimizeManhattanDistancesAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[3, 10], [5, 15], [10, 2], [4, 4]];
            int exp = 12;
            int res = alg.MinimumDistance(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 1], [1, 1], [1, 1]];
            int exp = 0;
            int res = alg.MinimumDistance(points);
            Assert.AreEqual(exp, res);
        }
    }
}
