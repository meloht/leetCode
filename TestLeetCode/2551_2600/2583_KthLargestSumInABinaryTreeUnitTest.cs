using leetCode._2551_2600;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2583_KthLargestSumInABinaryTreeUnitTest
    {
        _2583_KthLargestSumInABinaryTreeAlg alg=new _2583_KthLargestSumInABinaryTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 8, 9, 2, 1, 3, 7, 4, 6];
            var tree=TreeNode.BuildTree(root);
            int k = 2;
            int exp = 13;
            long res = alg.KthLargestLevelSum(tree, k);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, null, 3];
            var tree = TreeNode.BuildTree(root);
            int k = 1;
            int exp = 3;
            long res = alg.KthLargestLevelSum(tree, k);
            Assert.AreEqual(exp, res);
        }
    }
}
