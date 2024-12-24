using leetCode._0651_0700;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _669_TrimABinarySearchTreeTest
    {
        _669_TrimABinarySearchTreeAlg alg = new _669_TrimABinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 0, 2];
            int low = 1, high = 2;
            int?[] exp = [1, null, 2];
            var tree = TreeNode.BuildTree(root);
            var res = alg.TrimBST(tree,low,high);
            int?[] ress = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(ress));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [3, 0, 4, null, 2, null, null, 1];
            int low = 1, high = 3;
            int?[] exp = [3, 2, null, 1];
            var tree = TreeNode.BuildTree(root);
            var res = alg.TrimBST(tree, low, high);
            int?[] ress = TreeNode.GetTreeLevelList(res);
            Assert.IsTrue(exp.SequenceEqual(ress));
        }
    }
}
