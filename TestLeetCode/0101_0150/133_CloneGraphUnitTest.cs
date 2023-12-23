using leetCode;
using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _133_CloneGraphUnitTest
    {
        _133_CloneGraphAlg alg = new _133_CloneGraphAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] adjList = [[2, 4], [1, 3], [2, 4], [1, 3]];
            var root = GraphNode.Build(adjList);
            int[][] exp = [[2, 4], [1, 3], [2, 4], [1, 3]];
            var res = GraphNode.GetList(root);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] adjList = [[]];
            var root = GraphNode.Build(adjList);
            int[][] exp = [[]];
            var res = GraphNode.GetList(root);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[][] adjList = [];
            var root = GraphNode.Build(adjList);
            int[][] exp = [];
            var res = GraphNode.GetList(root);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
