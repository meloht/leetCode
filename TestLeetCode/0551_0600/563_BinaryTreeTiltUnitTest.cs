using leetCode._0551_0600;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _563_BinaryTreeTiltUnitTest
    {
        _563_BinaryTreeTiltAlg alg = new _563_BinaryTreeTiltAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3];
            var tree = TreeNode.BuildTree(root);
            int exp = 1;
            int res = alg.FindTilt(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [4, 2, 9, 3, 5, null, 7];
            var tree = TreeNode.BuildTree(root);
            int exp = 15;
            int res = alg.FindTilt(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [21, 7, 14, 1, 1, 2, 2, 3, 3];
            var tree = TreeNode.BuildTree(root);
            int exp = 9;
            int res = alg.FindTilt(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
