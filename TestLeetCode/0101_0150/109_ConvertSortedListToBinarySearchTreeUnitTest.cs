using leetCode._101_150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _109_ConvertSortedListToBinarySearchTreeUnitTest
    {
        _109_ConvertSortedListToBinarySearchTreeAlg alg = new _109_ConvertSortedListToBinarySearchTreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-10, -3, 0, 5, 9];
            var listNode = Utils.BuildListNode(nums);
            var tree = alg.SortedListToBST(listNode);
            var res = Utils.GetTreeLevelList(tree);
            int?[] exp1 = [0, -3, 9, -10, null, 5];
            int?[] exp2 = [0, -10, 5, null, -3, null, 9];
            bool bl = exp1.SequenceEqual(res) || exp2.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [];
            var listNode = Utils.BuildListNode(nums);
            var tree = alg.SortedListToBST(listNode);
            var res = Utils.GetTreeLevelList(tree);
            int?[] exp1 = [];
            bool bl = exp1.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
