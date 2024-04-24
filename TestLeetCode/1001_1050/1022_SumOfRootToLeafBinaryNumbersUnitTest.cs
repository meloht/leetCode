using leetCode._1001_1050;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1022_SumOfRootToLeafBinaryNumbersUnitTest
    {
        _1022_SumOfRootToLeafBinaryNumbersAlg alg = new _1022_SumOfRootToLeafBinaryNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 0, 1, 0, 1, 0, 1];
            int exp = 22;
            var tree = TreeNode.BuildTree(root);
            int res = alg.SumRootToLeaf(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [0];
            int exp = 0;
            var tree = TreeNode.BuildTree(root);
            int res = alg.SumRootToLeaf(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
