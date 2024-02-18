using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace Test._0851_0900
{
    [TestClass]
    public class _876_MiddleOfTheLinkedListUnitTest
    {
        _876_MiddleOfTheLinkedListAlg alg = new _876_MiddleOfTheLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [1, 2, 3, 4, 5];
            var node = ListNode.BuildListNode(head);
            var res = alg.MiddleNode(node);
            int[] rr = ListNode.GetLinkNodeList(res);
            int[] exp = [3, 4, 5];
            Assert.IsTrue(exp.SequenceEqual(rr));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [1, 2, 3, 4, 5, 6];
            var node = ListNode.BuildListNode(head);
            var res = alg.MiddleNode(node);
            int[] rr = ListNode.GetLinkNodeList(res);
            int[] exp = [4, 5, 6];
            Assert.IsTrue(exp.SequenceEqual(rr));
        }
    }
}
