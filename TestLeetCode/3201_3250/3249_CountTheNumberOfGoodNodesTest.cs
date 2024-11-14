using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3249_CountTheNumberOfGoodNodesTest
    {
        _3249_CountTheNumberOfGoodNodesAlg alg = new _3249_CountTheNumberOfGoodNodesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] edges = [[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]];
            int exp = 7;
            int res = alg.CountGoodNodes(edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] edges = [[0, 1], [1, 2], [2, 3], [3, 4], [0, 5], [1, 6], [2, 7], [3, 8]];
            int exp = 6;
            int res = alg.CountGoodNodes(edges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] edges = [[0, 1], [1, 2], [1, 3], [1, 4], [0, 5], [5, 6], [6, 7], [7, 8], [0, 9], [9, 10], [9, 12], [10, 11]];
            int exp = 12;
            int res = alg.CountGoodNodes(edges);
            Assert.AreEqual(exp, res);
        }
    }
}
