using leetCode._0601_0650;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _617_MergeTwoBinaryTreesUnitTest
    {
        _617_MergeTwoBinaryTreesAlg alg = new _617_MergeTwoBinaryTreesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root1 = [1, 3, 2, 5], root2 = [2, 1, 3, null, 4, null, 7];
            int?[] exp = [3, 4, 5, 5, 4, null, 7];

            var tree1 = TreeNode.BuildTree(root1);
            var tree2 = TreeNode.BuildTree(root2);

            var tree = alg.MergeTrees(tree1, tree2);
            int?[] res = TreeNode.GetTreeLevelList(tree);

            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root1 = [1], root2 = [1, 2];
            int?[] exp = [2, 2];

            var tree1 = TreeNode.BuildTree(root1);
            var tree2 = TreeNode.BuildTree(root2);

            var tree = alg.MergeTrees(tree1, tree2);
            int?[] res = TreeNode.GetTreeLevelList(tree);

            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
