﻿using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _226_InvertBinaryTreeUnitTest
    {
        _226_InvertBinaryTreeAlg alg = new _226_InvertBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [4, 2, 7, 1, 3, 6, 9];
            var tree = Utils.BuildTree(root);
            var res = alg.InvertTree(tree);
            int[] exp = [4, 7, 2, 9, 6, 3, 1];
            int[] arr = Utils.GetTreeLevel(res);
            Assert.IsTrue(exp.SequenceEqual(arr));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [2, 1, 3];
            var tree = Utils.BuildTree(root);
            var res = alg.InvertTree(tree);
            int[] exp = [2, 3, 1];
            int[] arr = Utils.GetTreeLevel(res);
            Assert.IsTrue(exp.SequenceEqual(arr));
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [];
            var tree = Utils.BuildTree(root);
            var res = alg.InvertTree(tree);
            int[] exp = [];
            int[] arr = Utils.GetTreeLevel(res);
            Assert.IsTrue(exp.SequenceEqual(arr));
        }
    }
}
