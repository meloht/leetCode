using leetCode;
using leetCode._2151_2200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2151_2200
{
    [TestClass]
    public class _2181_MergeNodesInBetweenZerosTest
    {
        _2181_MergeNodesInBetweenZerosAlg alg = new _2181_MergeNodesInBetweenZerosAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [0, 3, 1, 0, 4, 5, 2, 0];
            int[] exp = [4, 11];

            ListNode listNode = ListNode.BuildListNode(head);
            var resNode = alg.MergeNodes(listNode);
            int[] res = ListNode.GetLinkNodeList(resNode);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [0, 1, 0, 3, 0, 2, 2, 0];
            int[] exp = [1, 3, 4];

            ListNode listNode = ListNode.BuildListNode(head);
            var resNode = alg.MergeNodes(listNode);
            int[] res = ListNode.GetLinkNodeList(resNode);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
