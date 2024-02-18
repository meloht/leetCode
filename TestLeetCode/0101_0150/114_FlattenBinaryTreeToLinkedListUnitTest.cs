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
    public class _114_FlattenBinaryTreeToLinkedListUnitTest
    {
        _114_FlattenBinaryTreeToLinkedListAlg alg = new _114_FlattenBinaryTreeToLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 5, 3, 4, null, 6];
            var tree = TreeNode.BuildTree(root);
            alg.Flatten(tree);
            int?[] res= TreeNode.GetTreeList(tree);
            int?[] exp = [1, null, 2, null, 3, null, 4, null, 5, null, 6];

            bool bl = exp.SequenceEqual(res);

            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];
            var tree = TreeNode.BuildTree(root);
            alg.Flatten(tree);
            int?[] res = TreeNode.GetTreeList(tree);
            int?[] exp = [];

            bool bl = exp.SequenceEqual(res);

            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [0];
            var tree = TreeNode.BuildTree(root);
            alg.Flatten(tree);
            int?[] res = TreeNode.GetTreeList(tree);
            int?[] exp = [0];

            bool bl = exp.SequenceEqual(res);

            Assert.AreEqual(true, bl);
        }
    }
}
