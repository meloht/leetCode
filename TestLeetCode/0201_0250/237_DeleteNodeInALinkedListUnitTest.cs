using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace Test._0201_0250
{
    [TestClass]
    public class _237_DeleteNodeInALinkedListUnitTest
    {
        _237_DeleteNodeInALinkedListAlg alg = new _237_DeleteNodeInALinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [4, 5, 1, 9];
            var list = ListNode.BuildListNode(head);
            var node = list.next;
            alg.DeleteNode(node);
            var res = ListNode.GetLinkNodeList(list);

            int[] exp = [4, 1, 9];
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [4, 5, 1, 9];
            var list = ListNode.BuildListNode(head);
            var node = list.next.next;
            alg.DeleteNode(node);
            var res = ListNode.GetLinkNodeList(list);

            int[] exp = [4, 5, 9];
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
