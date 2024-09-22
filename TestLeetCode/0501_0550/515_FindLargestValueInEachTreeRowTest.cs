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
    public class _515_FindLargestValueInEachTreeRowTest
    {
        _515_FindLargestValueInEachTreeRowAlg alg = new _515_FindLargestValueInEachTreeRowAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [1, 3, 2, 5, 3, null, 9];
            int[] exp = [1, 3, 9];
            TreeNode node = TreeNode.BuildTree(root);
            var res = alg.LargestValues(node);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3];
            int[] exp = [1, 3];
            TreeNode node = TreeNode.BuildTree(root);
            var res = alg.LargestValues(node);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
