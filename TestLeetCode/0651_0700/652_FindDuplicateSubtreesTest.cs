using leetCode._0651_0700;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _652_FindDuplicateSubtreesTest
    {
        _652_FindDuplicateSubtreesAlg alg = new _652_FindDuplicateSubtreesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, null, 2, 4, null, null, 4];
            var tree = TreeNode.BuildTree(root);
            var trees = alg.FindDuplicateSubtrees(tree);
            int?[][] exp = [[2, 4], [4]];
            int?[][] res = TreeNode.GetTreeLevelLists(trees).ToArray();
            Assert.IsTrue(Utils.IsSame(exp, res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [2, 1, 1];
            var tree = TreeNode.BuildTree(root);
            var trees = alg.FindDuplicateSubtrees(tree);
            int?[][] exp = [[1]];
            int?[][] res = TreeNode.GetTreeLevelLists(trees).ToArray();
            Assert.IsTrue(Utils.IsSame(exp, res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [2, 2, 2, 3, null, 3, null];
            var tree = TreeNode.BuildTree(root);
            var trees = alg.FindDuplicateSubtrees(tree);
            int?[][] exp = [[2, 3], [3]];
            int?[][] res = TreeNode.GetTreeLevelLists(trees).ToArray();
            Assert.IsTrue(Utils.IsSame(exp, res));

        }
    }
}
