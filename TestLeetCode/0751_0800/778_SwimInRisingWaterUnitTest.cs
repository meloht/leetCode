using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _778_SwimInRisingWaterUnitTest
    {
        _778_SwimInRisingWaterAlg alg = new _778_SwimInRisingWaterAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 2], [1, 3]];
            int exp = 3;
            int res = alg.SwimInWater(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 1, 2, 3, 4], [24, 23, 22, 21, 5], [12, 13, 14, 15, 16], [11, 17, 18, 19, 20], [10, 9, 8, 7, 6]];
            int exp = 16;
            int res = alg.SwimInWater(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
