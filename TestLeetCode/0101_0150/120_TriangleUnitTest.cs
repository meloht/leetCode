using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _120_TriangleUnitTest
    {
        _120_TriangleAlg alg = new _120_TriangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] arr = { [2], [3, 4], [6, 5, 7], [4, 1, 8, 3] };
            int res = alg.MinimumTotal(arr);
            Assert.AreEqual(11, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] arr = { [-10] };
            int res = alg.MinimumTotal(arr);
            Assert.AreEqual(-10, res);
        }
    }
}
