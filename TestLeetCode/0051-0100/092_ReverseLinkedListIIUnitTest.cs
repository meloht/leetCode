using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _92_ReverseLinkedListIIUnitTest
    {
        _92_ReverseLinkedListIIAlg alg = new _92_ReverseLinkedListIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            ListNode node1 = Utils.BuildListNode(new int[] { 1, 2, 3, 4, 5 });
            var res = alg.ReverseBetween(node1, 2, 4);
            int[] arr = { 1, 4, 3, 2, 5 };

            bool bl = Utils.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }


        [TestMethod]
        public void TestCase02()
        {
            ListNode node1 = Utils.BuildListNode(new int[] { 5 });
            var res = alg.ReverseBetween(node1, 1, 1);
            int[] arr = { 5 };

            bool bl = Utils.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            ListNode node1 = Utils.BuildListNode(new int[] { 1, 2, 3 });
            var res = alg.ReverseBetween(node1, 3, 3);
            int[] arr = { 1, 2, 3 };

            bool bl = Utils.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }
    }
}
