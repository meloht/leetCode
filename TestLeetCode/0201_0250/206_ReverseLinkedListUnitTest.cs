﻿using leetCode;
using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test._0201_0250
{
    [TestClass]
    public class _206_ReverseLinkedListUnitTest
    {
        _206_ReverseLinkedListAlg alg = new _206_ReverseLinkedListAlg();

        [TestMethod]
        public void TestCase01()
        {
            ListNode node1 = ListNode.BuildListNode(new int[] { 1, 2, 3, 4, 5 });
            var res = alg.ReverseList(node1);
            int[] arr = { 5, 4, 3, 2, 1 };

            bool bl = ListNode.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            ListNode node1 = ListNode.BuildListNode(new int[] { 1, 2 });
            var res = alg.ReverseList(node1);
            int[] arr = { 2, 1 };

            bool bl = ListNode.ListNodeSame(res, arr);

            Assert.AreEqual(true, bl);
        }
    }
}
