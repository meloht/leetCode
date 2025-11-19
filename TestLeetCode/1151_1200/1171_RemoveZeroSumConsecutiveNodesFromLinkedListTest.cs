using leetCode;
using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1171_RemoveZeroSumConsecutiveNodesFromLinkedListTest
    {
        _1171_RemoveZeroSumConsecutiveNodesFromLinkedListAlg alg = new _1171_RemoveZeroSumConsecutiveNodesFromLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, -3, 3, 1];
            int[] exp = [3, 1];
            ListNode node = ListNode.BuildListNode(head);
            var res = alg.RemoveZeroSumSublists(node);
            int[] ress = ListNode.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(ress));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2, 3, -3, 4];
            int[] exp = [1, 2, 4];
            ListNode node = ListNode.BuildListNode(head);
            var res = alg.RemoveZeroSumSublists(node);
            int[] ress = ListNode.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(ress));

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] head = [1, 2, 3, -3, -2];
            int[] exp = [1];
            ListNode node = ListNode.BuildListNode(head);
            var res = alg.RemoveZeroSumSublists(node);
            int[] ress = ListNode.GetLinkNodeList(res);
            Assert.IsTrue(exp.SequenceEqual(ress));

        }
    }
}
