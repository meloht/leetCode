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
    public class _653_TwoSumIVInputIsABstUnitTest
    {
        _653_TwoSumIVInputIsABstAlg alg = new _653_TwoSumIVInputIsABstAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 3, 6, 2, 4, null, 7];
            int k = 9;
            bool exp = true;
            var tree = TreeNode.BuildTree(root);
            bool res = alg.FindTarget(tree, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 3, 6, 2, 4, null, 7];
            int k = 28;
            bool exp = false;
            var tree = TreeNode.BuildTree(root);
            bool res = alg.FindTarget(tree, k);
            Assert.AreEqual(exp, res);
        }
    }
}
