using leetCode._0551_0600;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _572_SubtreeOfAnotherTreeUnitTest
    {
        _572_SubtreeOfAnotherTreeAlg alg = new _572_SubtreeOfAnotherTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 4, 5, 1, 2], subRoot = [4, 1, 2];
            var tree1 = TreeNode.BuildTree(root);
            var tree2 = TreeNode.BuildTree(subRoot);
            bool exp = true;
            bool res = alg.IsSubtree(tree1, tree2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [3, 4, 5, 1, 2, null, null, null, null, 0], subRoot = [4, 1, 2];
            var tree1 = TreeNode.BuildTree(root);
            var tree2 = TreeNode.BuildTree(subRoot);
            bool exp = false;
            bool res = alg.IsSubtree(tree1, tree2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1,1], subRoot = [1];
            var tree1 = TreeNode.BuildTree(root);
            var tree2 = TreeNode.BuildTree(subRoot);
            bool exp = true;
            bool res = alg.IsSubtree(tree1, tree2);
            Assert.AreEqual(exp, res);
        }
    }
}
