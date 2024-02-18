using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace Test._0201_0250
{
    [TestClass]
    public class _222_CountCompleteTreeNodesUnitTest
    {
        _222_CountCompleteTreeNodesAlg alg = new _222_CountCompleteTreeNodesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 2, 3, 4, 5, 6];
            var tree = TreeNode.BuildTree(root);
            int exp = 6;
            int res = alg.CountNodes(tree);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];
            var tree = TreeNode.BuildTree(root);
            int exp = 0;
            int res = alg.CountNodes(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1];
            var tree = TreeNode.BuildTree(root);
            int exp = 1;
            int res = alg.CountNodes(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
