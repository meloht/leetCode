using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3195_FindTheMinimumAreaToCoverAllOnesITest
    {
        _3195_FindTheMinimumAreaToCoverAllOnesIAlg alg = new _3195_FindTheMinimumAreaToCoverAllOnesIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1, 0], [1, 0, 1]];
            int exp = 6;
            int res = alg.MinimumArea(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 0], [1, 0]];
            int exp = 1;
            int res = alg.MinimumArea(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
