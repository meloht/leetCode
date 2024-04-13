using leetCode._0651_0700;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _671_SecondMinimumNodeInABinaryTreeUnitTest
    {
        _671_SecondMinimumNodeInABinaryTreeAlg alg = new _671_SecondMinimumNodeInABinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [2, 2, 5, null, null, 5, 7];
            var tree = TreeNode.BuildTree(root);
            int exp = 5;
            int res = alg.FindSecondMinimumValue(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [2, 2, 2];
            var tree = TreeNode.BuildTree(root);
            int exp = -1;
            int res = alg.FindSecondMinimumValue(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 1, 3, 1, 1, 3, 4, 3, 1, 1, 8];
            var tree = TreeNode.BuildTree(root);
            int exp = 3;
            int res = alg.FindSecondMinimumValue(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
