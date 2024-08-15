using leetCode._3101_3150;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3148_MaximumDifferenceScoreInAGridTest
    {
        _3148_MaximumDifferenceScoreInAGridAlg alg = new _3148_MaximumDifferenceScoreInAGridAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[9, 5, 7, 3], [8, 9, 6, 1], [6, 7, 14, 3], [2, 5, 3, 1]];
            int exp = 9;
            int res = alg.MaxScore(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[4, 3, 2], [3, 2, 1]];
            int exp = -1;
            int res = alg.MaxScore(grid);
            Assert.AreEqual(exp, res);
        }

    }
}
