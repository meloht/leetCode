using leetCode._0901_0950;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _938_RangeSumOfBstUnitTest
    {
        _938_RangeSumOfBstAlg alg = new _938_RangeSumOfBstAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [10, 5, 15, 3, 7, null, 18];
            int low = 7, high = 15;
            int exp = 32;
            var tree = TreeNode.BuildTree(root);
            int res = alg.RangeSumBST(tree, low, high);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [10, 5, 15, 3, 7, 13, 18, 1, null, 6];
            int low = 6, high = 10;
            int exp = 23;
            var tree = TreeNode.BuildTree(root);
            int res = alg.RangeSumBST(tree, low, high);
            Assert.AreEqual(exp, res);
        }
    }
}
