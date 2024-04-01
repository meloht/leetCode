using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _310_MinimumHeightTreesUnitTest
    {
        _310_MinimumHeightTreesAlg alg = new _310_MinimumHeightTreesAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int[][] edges = [[1, 0], [1, 2], [1, 3]];
            int[] exp = [1];
            int[] res = alg.FindMinHeightTrees(n, edges).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6;
            int[][] edges = [[3, 0], [3, 1], [3, 2], [3, 4], [5, 4]];
            int[] exp = [3, 4];
            int[] res = alg.FindMinHeightTrees(n, edges).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
