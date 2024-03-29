﻿using leetCode;
using leetCode._51_100;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _94_BinaryTreeInorderTraversalUnitTest
    {
        _94_BinaryTreeInorderTraversalAlg alg = new _94_BinaryTreeInorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = { 1, null, 2, 3 };
            TreeNode root = TreeNode.BuildTree(arr);

            var res = alg.InorderTraversal(root);
            int[] exp = { 1, 3, 2 };
            bool bl = exp.SequenceEqual(res);
            Assert.AreEqual(true, bl);

        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = { };
            TreeNode root = TreeNode.BuildTree(arr);

            var res = alg.InorderTraversal(root);
            int[] exp = { };
            bool bl = exp.SequenceEqual(res);
            Assert.AreEqual(true, bl);

        }
        [TestMethod]
        public void TestCase03()
        {
            int?[] arr = { 1 };
            TreeNode root = TreeNode.BuildTree(arr);

            var res = alg.InorderTraversal(root);
            int[] exp = { 1 };
            bool bl = exp.SequenceEqual(res);
            Assert.AreEqual(true, bl);

        }
    }
}
