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
    public class _700_SearchInABinarySearchTreeUnitTest
    {
        _700_SearchInABinarySearchTreeAlg alg = new _700_SearchInABinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [4, 2, 7, 1, 3];
            int val = 2;
            int?[] exp = [2, 1, 3];
            var tree = TreeNode.BuildTree(root);
            var rest = alg.SearchBST(tree, val);
            int?[] res = TreeNode.GetTreeLevelList(rest);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [4, 2, 7, 1, 3];
            int val = 5;
            int?[] exp = [];
            var tree = TreeNode.BuildTree(root);
            var rest = alg.SearchBST(tree, val);
            int?[] res = TreeNode.GetTreeLevelList(rest);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }

}
