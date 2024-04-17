using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _812_LargestTriangleAreaUnitTest
    {
        _812_LargestTriangleAreaAlg alg = new _812_LargestTriangleAreaAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] points = [[0, 0], [0, 1], [1, 0], [0, 2], [2, 0]];
            double exp = 2.00000;
            double res = alg.LargestTriangleArea(points);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] points = [[1, 0], [0, 0], [0, 1]];
            double exp = 0.50000;
            double res = alg.LargestTriangleArea(points);
            Assert.AreEqual(exp, res);
        }
    }
}
