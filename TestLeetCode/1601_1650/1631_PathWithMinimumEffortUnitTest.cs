using leetCode._1601_1650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1601_1650
{
    [TestClass]
    public class _1631_PathWithMinimumEffortUnitTest
    {
        _1631_PathWithMinimumEffortAlg alg = new _1631_PathWithMinimumEffortAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] heights = [[1, 2, 2], [3, 8, 2], [5, 3, 5]];
            int exp = 2;
            int res = alg.MinimumEffortPath(heights);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] heights = [[1, 2, 3], [3, 8, 4], [5, 3, 5]];
            int exp = 1;
            int res = alg.MinimumEffortPath(heights);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] heights = [[1, 2, 1, 1, 1], [1, 2, 1, 2, 1], [1, 2, 1, 2, 1], [1, 2, 1, 2, 1], [1, 1, 1, 2, 1]];
            int exp = 0;
            int res = alg.MinimumEffortPath(heights);
            Assert.AreEqual(exp, res);
        }
    }
}
