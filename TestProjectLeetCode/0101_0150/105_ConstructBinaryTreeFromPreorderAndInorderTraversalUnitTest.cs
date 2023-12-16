using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _105_ConstructBinaryTreeFromPreorderAndInorderTraversalUnitTest
    {
        _105_ConstructBinaryTreeFromPreorderAndInorderTraversalAlg alg = new _105_ConstructBinaryTreeFromPreorderAndInorderTraversalAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[] preorder = [3, 9, 20, 15, 7];
            int[] inorder = [9, 3, 15, 20, 7];

            int?[] exp = [3, 9, 20, null, null, 15, 7];

            var tree = alg.BuildTree(preorder, inorder);

            var res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] preorder = [-1];
            int[] inorder = [-1];

            int?[] exp = [-1];

            var tree = alg.BuildTree(preorder, inorder);

            var res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] preorder = [1, 2, 3];
            int[] inorder = [2, 3, 1];

            int?[] exp = [1, 2, null, null, 3];

            var tree = alg.BuildTree(preorder, inorder);

            var res = Utils.GetTreeList(tree);

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
