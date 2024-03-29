﻿using leetCode._51_100;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _98_ValidateBinarySearchTreeUnitTest
    {
        _98_ValidateBinarySearchTreeAlg alg = new _98_ValidateBinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] arr = { 2, 1, 3 };
            var tree = TreeNode.BuildTree(arr);
            var bl= alg.IsValidBST(tree);
            Assert.AreEqual(bl,true);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] arr = { 5, 1, 4, null, null, 3, 6 };
            var tree = TreeNode.BuildTree(arr);
            var bl = alg.IsValidBST(tree);
            Assert.AreEqual(bl,false);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] arr = { 5, 4, 6, null, null, 3, 7 };
            var tree = TreeNode.BuildTree(arr);
            var bl = alg.IsValidBST(tree);
            Assert.AreEqual(bl, false);
        }

        [TestMethod]
        public void TestCase04()
        {
            int?[] arr = { 32, 26, 47, 19, null, null, 56, null, 27 };
            var tree = TreeNode.BuildTree(arr);
            var bl = alg.IsValidBST(tree);
            Assert.AreEqual(bl, false);
        }
    }
}
