using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _145_BinaryTreePostorderTraversalUnitTest
    {
        _145_BinaryTreePostorderTraversalAlg alg = new _145_BinaryTreePostorderTraversalAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, null, 2, 3];
            var tree = Utils.BuildTree(root);
            var res = alg.PostorderTraversal(tree);
            int[] exp = [3, 2, 1];
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [];
            var tree = Utils.BuildTree(root);
            var res = alg.PostorderTraversal(tree);
            int[] exp = [];
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int?[] root = [1];
            var tree = Utils.BuildTree(root);
            var res = alg.PostorderTraversal(tree);
            int[] exp = [1];
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }


        [TestMethod]
        public void TestCase04()
        {
            int?[] root = [3, 9, 20, null,null, 15, 7];
            var tree = Utils.BuildTree(root);
            var res = alg.PostorderTraversal(tree);
            int[] exp = [9, 15, 7, 20, 3];
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
