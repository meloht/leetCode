using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _803_BricksFallingWhenHitUnitTest
    {
        _803_BricksFallingWhenHitAlg alg = new _803_BricksFallingWhenHitAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [
                [1, 0, 0, 0], 
                [1, 1, 1, 0]], hits = [[1, 0]];
            int[] exp = [2];
            int[] res = alg.HitBricks(grid, hits);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [
                [1, 0, 0, 0], 
                [1, 1, 0, 0]], hits = [[1, 1], [1, 0]];
            int[] exp = [0, 0];
            int[] res = alg.HitBricks(grid, hits);
            Assert.IsTrue(exp.SequenceEqual(res));
        }


    }
}
