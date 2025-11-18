using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1162_AsFarFromLandAsPossibleTest
    {
        _1162_AsFarFromLandAsPossibleAlg alg = new _1162_AsFarFromLandAsPossibleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 0, 1], [0, 0, 0], [1, 0, 1]];
            int exp = 2;
            int res = alg.MaxDistance(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 0, 0], [0, 0, 0], [0, 0, 0]];
            int exp = 4;
            int res = alg.MaxDistance(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
