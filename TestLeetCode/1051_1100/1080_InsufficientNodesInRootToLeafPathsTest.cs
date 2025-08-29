using leetCode._1051_1100;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1080_InsufficientNodesInRootToLeafPathsTest
    {
        _1080_InsufficientNodesInRootToLeafPathsAlg alg = new _1080_InsufficientNodesInRootToLeafPathsAlg();

        [TestMethod]
        public void Test01()
        {
            int?[] root = [1, 2, 3, 4, -99, -99, 7, 8, 9, -99, -99, 12, 13, -99, 14];
            int limit = 1;
            int?[] exp = [1, 2, 3, 4, null, null, 7, 8, 9, null, 14];
            TreeNode tree = TreeNode.BuildTree(root);
            TreeNode ress = alg.SufficientSubset(tree, limit);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int?[] root = [5, 4, 8, 11, null, 17, 4, 7, 1, null, null, 5, 3];
            int limit = 22;
            int?[] exp = [5, 4, 8, 11, null, 17, 4, 7, null, null, null, 5];
            TreeNode tree = TreeNode.BuildTree(root);
            TreeNode ress = alg.SufficientSubset(tree, limit);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test03()
        {
            int?[] root = [1, 2, -3, -5, null, 4, null];
            int limit = -1;
            int?[] exp = [1, null, -3, 4];
            TreeNode tree = TreeNode.BuildTree(root);
            TreeNode ress = alg.SufficientSubset(tree, limit);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void Test04()
        {
            int?[] root = [2, 7, 2, null, 8, null, null, null, 4];
            int limit = 15;
            int?[] exp = [2, 7, null, null, 8, null, 4];
            TreeNode tree = TreeNode.BuildTree(root);
            TreeNode ress = alg.SufficientSubset(tree, limit);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
