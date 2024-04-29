using leetCode;
using leetCode._0301_0350;
using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _328_OddEvenLinkedListUnitTest
    {
        _328_OddEvenLinkedListAlg alg = new _328_OddEvenLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, 3, 4, 5];
            int[] exp = [1, 3, 5, 2, 4];
            var tree = ListNode.BuildListNode(head);
            var res = alg.OddEvenList(tree);

            int[] arr = ListNode.GetLinkNodeList(res);
            Assert.IsTrue(arr.SequenceEqual(exp));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [2, 1, 3, 5, 6, 4, 7];
            int[] exp = [2, 3, 6, 7, 1, 5, 4];
            var tree = ListNode.BuildListNode(head);
            var res = alg.OddEvenList(tree);

            int[] arr = ListNode.GetLinkNodeList(res);
            Assert.IsTrue(arr.SequenceEqual(exp));
        }
    }
}
