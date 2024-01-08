using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _218_TheSkylineProblemUnitTest
    {
        _218_TheSkylineProblemAlg alg = new _218_TheSkylineProblemAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] buildings = [[2, 9, 10], [3, 7, 15], [5, 12, 12], [15, 20, 10], [19, 24, 8]];

            int[][] exp = [[2, 10], [3, 15], [7, 12], [12, 0], [15, 10], [20, 8], [24, 0]];

            var res = alg.GetSkyline(buildings);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] buildings = [[0, 2, 3], [2, 5, 3]];

            int[][] exp = [[0, 3], [5, 0]];

            var res = alg.GetSkyline(buildings);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] buildings = [[0, 2147483647, 2147483647]];

            int[][] exp = [[0, 2147483647], [2147483647, 0]];

            var res = alg.GetSkyline(buildings);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
