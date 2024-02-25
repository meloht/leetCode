using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _827_MakingALargeIslandUnitTest
    {
        _827_MakingALargeIslandAlg alg = new _827_MakingALargeIslandAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [
                [1, 0], 
                [0, 1]];
            int exp = 3;
            int res = alg.LargestIsland(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 1], [1, 0]];
            int exp = 4;
            int res = alg.LargestIsland(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 1], [1, 1]];
            int exp = 4;
            int res = alg.LargestIsland(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
