using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _144_BinaryTreePreorderTraversalUnitTest
    {
        _144_BinaryTreePreorderTraversalAlg alg = new _144_BinaryTreePreorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 2, 3];
            var tree = Utils.BuildTree(root);
            int[] exp = [1, 2, 3];
            var res = alg.PreorderTraversal(tree);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];
            var tree = Utils.BuildTree(root);
            int[] exp = [];
            var res = alg.PreorderTraversal(tree);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1];
            var tree = Utils.BuildTree(root);
            int[] exp = [1];
            var res = alg.PreorderTraversal(tree);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
