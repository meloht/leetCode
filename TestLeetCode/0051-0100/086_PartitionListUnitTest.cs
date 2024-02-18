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
    public class _86_PartitionListUnitTest
    {
        _86_PartitionListAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _86_PartitionListAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            ListNode node1 = ListNode.BuildListNode(new int[] { 1, 4, 3, 2, 5, 2 });
            var res = alg.Partition(node1, 3);
            int[] arr = { 1, 2, 2, 4, 3, 5 };

            bool bl = ListNode.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            ListNode node1 = ListNode.BuildListNode(new int[] { 2, 1 });
            var res = alg.Partition(node1, 2);
            int[] arr = { 1, 2 };

            bool bl = ListNode.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }
    }
}
