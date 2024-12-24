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
    public class _662_MaximumWidthOfBinaryTreeTest
    {
        _662_MaximumWidthOfBinaryTreeAlg alg = new _662_MaximumWidthOfBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 3, 2, 5, 3, null, 9];
            int exp = 4;
            var tree = TreeNode.BuildTree(root);
            int res = alg.WidthOfBinaryTree(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 3, 2, 5, null, null, 9, 6, null, 7];
            int exp = 7;
            var tree = TreeNode.BuildTree(root);
            int res = alg.WidthOfBinaryTree(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, 3, 2, 5];
            int exp = 2;
            var tree = TreeNode.BuildTree(root);
            int res = alg.WidthOfBinaryTree(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
