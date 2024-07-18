using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3112_MinimumTimeToVisitDisappearingNodesTest
    {
        _3112_MinimumTimeToVisitDisappearingNodesAlg alg = new _3112_MinimumTimeToVisitDisappearingNodesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;int[][] edges = [[0, 1, 2], [1, 2, 1], [0, 2, 4]];
            int[] disappear = [1, 1, 5];
            int[] exp = [0, -1, 4];
            int[] res = alg.MinimumTime(n, edges, disappear);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3; int[][] edges = [[0, 1, 2], [1, 2, 1], [0, 2, 4]];
            int[] disappear = [1, 3, 5];
            int[] exp = [0, 2, 3];
            int[] res = alg.MinimumTime(n, edges, disappear);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2; int[][] edges = [[0, 1, 1]];
            int[] disappear = [1, 1];
            int[] exp = [0, -1];
            int[] res = alg.MinimumTime(n, edges, disappear);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
