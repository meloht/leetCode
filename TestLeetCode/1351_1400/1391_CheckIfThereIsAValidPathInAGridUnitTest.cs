using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1391_CheckIfThereIsAValidPathInAGridUnitTest
    {
        _1391_CheckIfThereIsAValidPathInAGridAlg alg = new _1391_CheckIfThereIsAValidPathInAGridAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[2, 4, 3], [6, 5, 2]];
            bool exp = true;
            bool res = alg.HasValidPath(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 2, 1], [1, 2, 1]];
            bool exp = false;
            bool res = alg.HasValidPath(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 1, 2]];
            bool exp = false;
            bool res = alg.HasValidPath(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] grid = [[1, 1, 1, 1, 1, 1, 3]];
            bool exp = true;
            bool res = alg.HasValidPath(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] grid = [[2], [2], [2], [2], [2], [2], [6]];
            bool exp = true;
            bool res = alg.HasValidPath(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
