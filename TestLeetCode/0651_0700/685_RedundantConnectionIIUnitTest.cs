using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _685_RedundantConnectionIIUnitTest
    {
        _685_RedundantConnectionIIAlg alg = new _685_RedundantConnectionIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] edges = [[1, 2], [1, 3], [2, 3]];
            int[] exp = [2, 3];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] edges = [[1, 2], [2, 3], [3, 4], [4, 1], [1, 5]];
            int[] exp = [4, 1];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] edges = [[2, 1], [3, 1], [4, 2], [1, 4]];
            int[] exp = [2, 1];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] edges = [[5, 2], [5, 1], [3, 1], [3, 4], [3, 5]];
            int[] exp = [3, 1];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] edges = [[4, 2], [1, 5], [5, 2], [5, 3], [2, 4]];
            int[] exp = [4, 2];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase06()
        {
            int[][] edges = [[2, 3], [3, 1], [3, 4], [4, 2]];
            int[] exp = [4, 2];
            int[] res = alg.FindRedundantDirectedConnection(edges);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
