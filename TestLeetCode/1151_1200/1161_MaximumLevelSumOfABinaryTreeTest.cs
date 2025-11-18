using leetCode._1151_1200;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1161_MaximumLevelSumOfABinaryTreeTest
    {
        _1161_MaximumLevelSumOfABinaryTreeAlg alg = new _1161_MaximumLevelSumOfABinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 7, 0, 7, -8, null, null];
            TreeNode node = TreeNode.BuildTree(root);
            int exp = 2;
            int res = alg.MaxLevelSum(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [989, null, 10250, 98693, -89388, null, null, null, -32127];
            TreeNode node = TreeNode.BuildTree(root);
            int exp = 2;
            int res = alg.MaxLevelSum(node);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [-100, -200, -300, -20, -5, -10, null];
            TreeNode node = TreeNode.BuildTree(root);
            int exp = 3;
            int res = alg.MaxLevelSum(node);
            Assert.AreEqual(exp, res);
        }
    }
}
