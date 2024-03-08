using leetCode._0401_0450;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _404_SumOfLeftLeavesUnitTest
    {
        _404_SumOfLeftLeavesAlg alg = new _404_SumOfLeftLeavesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [3, 9, 20, null, null, 15, 7];
            var tree = TreeNode.BuildTree(root);
            int exp = 24;
            int res = alg.SumOfLeftLeaves(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1];
            var tree = TreeNode.BuildTree(root);
            int exp = 0;
            int res = alg.SumOfLeftLeaves(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
