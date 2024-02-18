using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace Test._0101_0150
{
    [TestClass]
    public class _111_MinimumDepthOfBinaryTreeUnitTest
    {
        _111_MinimumDepthOfBinaryTreeAlg alg = new _111_MinimumDepthOfBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 9, 20, null, null, 15, 7];
            var tree = TreeNode.BuildTree(root);
            int num = alg.MinDepth(tree);
            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [2, null, 3, null, 4, null, 5, null, 6];
            var tree = TreeNode.BuildTree(root);
            int num = alg.MinDepth(tree);
            Assert.AreEqual(5, num);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [-9, -3, 2, null, 4, 4, 0, -6, null, -5];
            var tree = TreeNode.BuildTree(root);
            int num = alg.MinDepth(tree);
            Assert.AreEqual(3, num);
        }
    }
}
