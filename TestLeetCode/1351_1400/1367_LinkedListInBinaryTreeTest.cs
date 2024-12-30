using leetCode;
using leetCode._1351_1400;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1367_LinkedListInBinaryTreeTest
    {
        _1367_LinkedListInBinaryTreeAlg alg = new _1367_LinkedListInBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [4, 2, 8];
            int?[] root = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
            var listNode = ListNode.BuildListNode(head);
            var tree = TreeNode.BuildTree(root);
            bool exp = true;
            bool res = alg.IsSubPath(listNode, tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [4, 2, 8];
            int?[] root = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
            var listNode = ListNode.BuildListNode(head);
            var tree = TreeNode.BuildTree(root);
            bool exp = true;
            bool res = alg.IsSubPath(listNode, tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] head = [1, 4, 2, 6, 8];
            int?[] root = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
            var listNode = ListNode.BuildListNode(head);
            var tree = TreeNode.BuildTree(root);
            bool exp = false;
            bool res = alg.IsSubPath(listNode, tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] head = [1, 10];
            int?[] root = [1, null, 1, 10, 1, 9];
            var listNode = ListNode.BuildListNode(head);
            var tree = TreeNode.BuildTree(root);
            bool exp = true;
            bool res = alg.IsSubPath(listNode, tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] head = [2, 2, 1];
            int?[] root = [2, null, 2, null, 2, null, 1];
            var listNode = ListNode.BuildListNode(head);
            var tree = TreeNode.BuildTree(root);
            bool exp = true;
            bool res = alg.IsSubPath(listNode, tree);
            Assert.AreEqual(exp, res);
        }
    }
}
