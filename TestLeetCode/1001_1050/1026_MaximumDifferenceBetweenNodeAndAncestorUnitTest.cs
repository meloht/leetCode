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
    public class _1026_MaximumDifferenceBetweenNodeAndAncestorUnitTest
    {
        _1026_MaximumDifferenceBetweenNodeAndAncestorAlg alg = new _1026_MaximumDifferenceBetweenNodeAndAncestorAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13];
            var tree = TreeNode.BuildTree(root);
            int exp = 7;
            int res = alg.MaxAncestorDiff(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, null, 2, null, 0, 3];
            var tree = TreeNode.BuildTree(root);
            int exp = 3;
            int res = alg.MaxAncestorDiff(tree);
            Assert.AreEqual(exp, res);
        }
    }
}
