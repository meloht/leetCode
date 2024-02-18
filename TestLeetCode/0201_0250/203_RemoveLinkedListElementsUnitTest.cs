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
    public class _203_RemoveLinkedListElementsUnitTest
    {
        _203_RemoveLinkedListElementsAlg alg = new _203_RemoveLinkedListElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 6, 3, 4, 5, 6];
            var head = ListNode.BuildListNode(arr);
            var res = alg.RemoveElements(head, 6);
            var ls = ListNode.GetLinkNodeList(res);
            int[] exp = [1, 2, 3, 4, 5];

            Assert.AreEqual(true, exp.SequenceEqual(ls));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [];
            var head = ListNode.BuildListNode(arr);
            var res = alg.RemoveElements(head, 1);
            var ls = ListNode.GetLinkNodeList(res);
            int[] exp = [];

            Assert.AreEqual(true, exp.SequenceEqual(ls));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [7, 7, 7, 7];
            var head = ListNode.BuildListNode(arr);
            var res = alg.RemoveElements(head, 7);
            var ls = ListNode.GetLinkNodeList(res);
            int[] exp = [];

            Assert.AreEqual(true, exp.SequenceEqual(ls));
        }
    }
}
