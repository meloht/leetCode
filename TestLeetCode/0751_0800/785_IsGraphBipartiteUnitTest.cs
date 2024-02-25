using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _785_IsGraphBipartiteUnitTest
    {
        _785_IsGraphBipartiteAlg alg = new _785_IsGraphBipartiteAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] graph = [[1, 2, 3], [0, 2], [0, 1, 3], [0, 2]];
            bool exp = false;
            bool res = alg.IsBipartite(graph);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] graph = [[1, 3], [0, 2], [1, 3], [0, 2]];
            bool exp = true;
            bool res = alg.IsBipartite(graph);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] graph = [[4], [], [4], [4], [0, 2, 3]];
            bool exp = true;
            bool res = alg.IsBipartite(graph);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] graph = [[], [2, 4, 6], [1, 4, 8, 9], [7, 8], [1, 2, 8, 9], [6, 9],
            [1, 5, 7, 8, 9], [3, 6, 9], [2, 3, 4, 6, 9], 
            [2, 4, 5, 6, 7, 8]];
            bool exp = false;
            bool res = alg.IsBipartite(graph);
            Assert.AreEqual(exp, res);
        }
    }
}
