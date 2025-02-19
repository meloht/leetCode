using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _802_FindEventualSafeStateTest
    {
        _802_FindEventualSafeStateAlg alg = new _802_FindEventualSafeStateAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] graph = [[1, 2], [2, 3], [5], [0], [5], [], []];
            int[] exp = [2, 4, 5, 6];
            int[] res = alg.EventualSafeNodes(graph).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] graph = [[1, 2, 3, 4], [1, 2], [3, 4], [0, 4], []];
            int[] exp = [4];
            int[] res = alg.EventualSafeNodes(graph).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
