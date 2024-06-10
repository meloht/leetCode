using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _407_TrappingRainWaterIIUnitTest
    {
        _407_TrappingRainWaterIIAlg alg = new _407_TrappingRainWaterIIAlg();

        [TestMethod]
        public void Test1()
        {
            int[][] heightMap = [[1, 4, 3, 1, 3, 2], [3, 2, 1, 3, 2, 4], [2, 3, 3, 2, 3, 1]];
            int exp = 4;
            int res = alg.TrapRainWater(heightMap);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test2()
        {
            int[][] heightMap = [[3, 3, 3, 3, 3], [3, 2, 2, 2, 3], [3, 2, 1, 2, 3], [3, 2, 2, 2, 3], [3, 3, 3, 3, 3]];
            int exp = 10;
            int res = alg.TrapRainWater(heightMap);
            Assert.AreEqual(exp, res);
        }
    }
}
