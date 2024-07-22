using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2101_DetonateTheMaximumBombsTest
    {
        _2101_DetonateTheMaximumBombsAlg alg = new _2101_DetonateTheMaximumBombsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] bombs = [[2, 1, 3], [6, 1, 4]];
            int exp = 2;
            int res = alg.MaximumDetonation(bombs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] bombs = [[1, 1, 5], [10, 10, 5]];
            int exp = 1;
            int res = alg.MaximumDetonation(bombs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] bombs = [[1, 2, 3], [2, 3, 1], [3, 4, 2], [4, 5, 3], [5, 6, 4]];
            int exp = 5;
            int res = alg.MaximumDetonation(bombs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] bombs = [[54, 95, 4], [99, 46, 3], [29, 21, 3], [96, 72, 8], [49, 43, 3], [11, 20, 3], [2, 57, 1], [69, 51, 7], [97, 1, 10], [85, 45, 2], [38, 47, 1], [83, 75, 3], [65, 59, 3], [33, 4, 1], [32, 10, 2], [20, 97, 8], [35, 37, 3]];
            int exp = 1;
            int res = alg.MaximumDetonation(bombs);
            Assert.AreEqual(exp, res);
        }
    }
}
