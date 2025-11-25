using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1219_PathWithMaximumGoldTest
    {
        _1219_PathWithMaximumGoldAlg alg = new _1219_PathWithMaximumGoldAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 6, 0], [5, 8, 7], [0, 9, 0]];
            int exp = 24;
            int res = alg.GetMaximumGold(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 0, 7], [2, 0, 6], [3, 4, 5], [0, 3, 0], [9, 0, 20]];
            int exp = 28;
            int res = alg.GetMaximumGold(grid);
            Assert.AreEqual(exp, res);
        }

       
    }
}
