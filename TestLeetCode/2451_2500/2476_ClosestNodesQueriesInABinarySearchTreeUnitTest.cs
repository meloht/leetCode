using leetCode._2451_2500;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2451_2500
{
    [TestClass]
    public class _2476_ClosestNodesQueriesInABinarySearchTreeUnitTest
    {
        _2476_ClosestNodesQueriesInABinarySearchTreeAlg alg = new _2476_ClosestNodesQueriesInABinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [6, 2, 13, 1, 4, 9, 15, null, null, null, null, null, null, 14];
            int[] queries = [2, 5, 16];
            IList<IList<int>> exp = [[2, 2], [4, 6], [15, -1]];
            var tree = TreeNode.BuildTree(root);
            var res = alg.ClosestNodes(tree, queries);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [4, null, 9];
            int[] queries = [3];
            IList<IList<int>> exp = [[-1, 4]];
            var tree = TreeNode.BuildTree(root);
            var res = alg.ClosestNodes(tree, queries);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
