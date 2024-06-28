using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2742_PaintingTheWallsTest
    {
        _2742_PaintingTheWallsAlg alg = new _2742_PaintingTheWallsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] cost = [1, 2, 3, 2];
            int[] time = [1, 2, 3, 2];
            int exp = 3;
            int res = alg.PaintWalls(cost, time);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] cost = [2, 3, 4, 2];
            int[] time = [1, 1, 1, 1];
            int exp = 4;
            int res = alg.PaintWalls(cost, time);
            Assert.AreEqual(exp, res);
        }

    }
}
