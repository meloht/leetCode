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
    public class _687_LongestUnivaluePathTest
    {
        _687_LongestUnivaluePathAlg alg = new _687_LongestUnivaluePathAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 4, 5, 1, 1, 5];
            var rootNode = TreeNode.BuildTree(root);
            int exp = 2;
            int res = alg.LongestUnivaluePath(rootNode);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 4, 5, 4, 4, 5];
            var rootNode = TreeNode.BuildTree(root);
            int exp = 2;
            int res = alg.LongestUnivaluePath(rootNode);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1, null, 1, 1, 1, 1, 1, 1];
            var rootNode = TreeNode.BuildTree(root);
            int exp = 4;
            int res = alg.LongestUnivaluePath(rootNode);
            Assert.AreEqual(exp, res);
        }
    }
}
