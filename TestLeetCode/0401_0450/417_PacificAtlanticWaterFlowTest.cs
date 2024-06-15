using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _417_PacificAtlanticWaterFlowTest
    {
        _417_PacificAtlanticWaterFlowAlg alg = new _417_PacificAtlanticWaterFlowAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] heights = [[1, 2, 2, 3, 5], [3, 2, 3, 4, 4], [2, 4, 5, 3, 1], [6, 7, 1, 4, 5], [5, 1, 1, 2, 4]];
            int[][] exp = [[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]];
            var res = alg.PacificAtlantic(heights);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] heights = [[2, 1], [1, 2]];
            int[][] exp = [[0, 0], [0, 1], [1, 0], [1, 1]];
            var res = alg.PacificAtlantic(heights);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
