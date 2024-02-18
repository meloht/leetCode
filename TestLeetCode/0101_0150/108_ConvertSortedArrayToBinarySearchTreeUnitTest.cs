using leetCode._101_150;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _108_ConvertSortedArrayToBinarySearchTreeUnitTest
    {
        _108_ConvertSortedArrayToBinarySearchTreeAlg alg = new _108_ConvertSortedArrayToBinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-10, -3, 0, 5, 9];
            var tree = alg.SortedArrayToBST(nums);
            var res = TreeNode.GetTreeLevelList(tree);
            int?[] exp1 = [0, -3, 9, -10, null, 5];
            int?[] exp2 = [0, -10, 5, null, -3, null, 9];
            bool bl = exp1.SequenceEqual(res) || exp2.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 3];
            var tree = alg.SortedArrayToBST(nums);
            var res = TreeNode.GetTreeLevelList(tree);
            int?[] exp1 = [3, 1];
            int?[] exp2 = [1, null, 3];
            bool bl = exp1.SequenceEqual(res) || exp2.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
