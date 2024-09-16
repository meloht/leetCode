using leetCode._0501_0550;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _508_MostFrequentSubtreeSumTest
    {
        _508_MostFrequentSubtreeSumAlg alg = new _508_MostFrequentSubtreeSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [5, 2, -3];
            int[] exp = [2, -3, 4];
            TreeNode node = TreeNode.BuildTree(root);
            int[] res = alg.FindFrequentTreeSum(node);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [5, 2, -5];
            int[] exp = [2];
            TreeNode node = TreeNode.BuildTree(root);
            int[] res = alg.FindFrequentTreeSum(node);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
