using leetCode._0951_1000;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0968_BinaryTreeCamerasUnitTest
    {
        _0968_BinaryTreeCamerasAlg alg = new _0968_BinaryTreeCamerasAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [0, 0, null, 0, 0];
            var tree = TreeNode.BuildTree(root);
            int exp = 1;
            int res = alg.MinCameraCover(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [0, 0, null, 0, null, 0, null, null, 0];
            var tree = TreeNode.BuildTree(root);
            int exp = 2;
            int res = alg.MinCameraCover(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
