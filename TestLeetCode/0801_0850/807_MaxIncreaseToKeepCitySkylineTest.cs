using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _807_MaxIncreaseToKeepCitySkylineTest
    {
        _807_MaxIncreaseToKeepCitySkylineAlg alg = new _807_MaxIncreaseToKeepCitySkylineAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[3, 0, 8, 4], [2, 4, 5, 7], [9, 2, 6, 3], [0, 3, 1, 0]];
            int exp = 35;
            int res = alg.MaxIncreaseKeepingSkyline(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];
            int exp = 0;
            int res = alg.MaxIncreaseKeepingSkyline(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
