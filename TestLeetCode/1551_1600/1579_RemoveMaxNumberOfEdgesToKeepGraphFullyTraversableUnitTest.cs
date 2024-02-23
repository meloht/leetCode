using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversableUnitTest
    {
        _1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversableAlg alg = new _1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversableAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int[][] edges = [[3, 1, 2], [3, 2, 3], [1, 1, 3], [1, 2, 4], [1, 1, 2], [2, 3, 4]];
            int exp = 2;
            int res = alg.MaxNumEdgesToRemove(n, edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 4;
            int[][] edges = [[3, 1, 2], [3, 2, 3], [1, 1, 4], [2, 1, 4]];
            int exp = 0;
            int res = alg.MaxNumEdgesToRemove(n, edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 4;
            int[][] edges = [[3, 2, 3], [1, 1, 2], [2, 3, 4]];
            int exp = -1;
            int res = alg.MaxNumEdgesToRemove(n, edges);
            Assert.AreEqual(exp, res);
        }
    }
}
