using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2923_FindChampionIUnitTest
    {
        _2923_FindChampionIAlg alg = new _2923_FindChampionIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1], [0, 0]];
            int exp = 0;
            int res = alg.FindChampion(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 0, 1], [1, 0, 1], [0, 0, 0]];
            int exp = 1;
            int res = alg.FindChampion(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
