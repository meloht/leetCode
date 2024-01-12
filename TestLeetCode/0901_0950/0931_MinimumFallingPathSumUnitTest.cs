using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0901_0950
{
    [TestClass]
    public class _0931_MinimumFallingPathSumUnitTest
    {
        _0931_MinimumFallingPathSumAlg alg = new _0931_MinimumFallingPathSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matrix = [[2, 1, 3], [6, 5, 4], [7, 8, 9]];
            int exp = 13;
            int res = alg.MinFallingPathSum(matrix);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] matrix = [[-19, 57], [-40, -5]];
            int exp = -59;
            int res = alg.MinFallingPathSum(matrix);
            Assert.AreEqual(exp, res);
        }
    }
}
