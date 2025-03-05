using leetCode._0801_0850;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _814_BinaryTreePruningTest
    {
        _814_BinaryTreePruningAlg alg = new _814_BinaryTreePruningAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 0, 0, 1];
            int?[] exp = [1, null, 0, null, 1];
            TreeNode node = TreeNode.BuildTree(root);
            var resNode = alg.PruneTree(node);
            int?[] res = TreeNode.GetTreeLevelList(resNode);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 0, 1, 0, 0, 0, 1];
            int?[] exp = [1, null, 1, null, 1];
            TreeNode node = TreeNode.BuildTree(root);
            var resNode = alg.PruneTree(node);
            int?[] res = TreeNode.GetTreeLevelList(resNode);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 1, 0, 1, 1, 0, 1, 0];
            int?[] exp = [1, 1, 0, 1, 1, null, 1];
            TreeNode node = TreeNode.BuildTree(root);
            var resNode = alg.PruneTree(node);
            int?[] res = TreeNode.GetTreeLevelList(resNode);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
