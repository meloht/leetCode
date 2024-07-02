using leetCode._0401_0450;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _450_DeleteNodeInABstTest
    {
        _450_DeleteNodeInABstAlg alg = new _450_DeleteNodeInABstAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 3, 6, 2, 4, null, 7];
            int key = 3;
            var node = TreeNode.BuildTree(root);
            int?[] exp = [5, 4, 6, 2, null, null, 7];
            var tree = alg.DeleteNode(node, key);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 3, 6, 2, 4, null, 7];
            int key = 0;
            var node = TreeNode.BuildTree(root);
            int?[] exp = [5, 3, 6, 2, 4, null, 7];
            var tree = alg.DeleteNode(node, key);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [];
            int key = 0;
            var node = TreeNode.BuildTree(root);
            int?[] exp = [];
            var tree = alg.DeleteNode(node, key);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] root = [50, 30, 70, null, 40, 60, 80];
            int key = 50;
            var node = TreeNode.BuildTree(root);
            int?[] exp = [70, 60, 80, 30, null, null, null, null, 40];
            var tree = alg.DeleteNode(node, key);
            int?[] res = TreeNode.GetTreeLevelList(tree);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
