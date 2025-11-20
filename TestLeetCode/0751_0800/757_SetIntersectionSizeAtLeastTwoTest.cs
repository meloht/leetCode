using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _757_SetIntersectionSizeAtLeastTwoTest
    {
        _757_SetIntersectionSizeAtLeastTwoAlg alg = new _757_SetIntersectionSizeAtLeastTwoAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] intervals = [[1, 3], [3, 7], [8, 9]];
            int exp = 5;
            int res = alg.IntersectionSizeTwo(intervals);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] intervals = [[1, 3], [1, 4], [2, 5], [3, 5]];
            int exp = 3;
            int res = alg.IntersectionSizeTwo(intervals);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] intervals = [[1, 2], [2, 3], [2, 4], [4, 5]];
            int exp = 5;
            int res = alg.IntersectionSizeTwo(intervals);
            Assert.AreEqual(exp, res);
        }
    }
}
