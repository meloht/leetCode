using leetCode._1101_1150;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1145_BinaryTreeColoringGameTest
    {
        _1145_BinaryTreeColoringGameAlg alg = new _1145_BinaryTreeColoringGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
            int n = 11, x = 3;
            TreeNode tree = TreeNode.BuildTree(root);
            bool exp = true;
            bool res = alg.BtreeGameWinningMove(tree, n, x);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3];
            int n = 3, x = 1;
            TreeNode tree = TreeNode.BuildTree(root);
            bool exp = false;
            bool res = alg.BtreeGameWinningMove(tree, n, x);
            Assert.AreEqual(exp, res);
        }
    }
}
