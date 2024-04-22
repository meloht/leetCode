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
    public class _0965_UnivaluedBinaryTreeUnitTest
    {
        _0965_UnivaluedBinaryTreeAlg alg = new _0965_UnivaluedBinaryTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 1, 1, 1, 1, null, 1];
            bool exp = true;
            var tree = TreeNode.BuildTree(root);
            bool res = alg.IsUnivalTree(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [2, 2, 2, 5, 2];
            bool exp = false;
            var tree = TreeNode.BuildTree(root);
            bool res = alg.IsUnivalTree(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
