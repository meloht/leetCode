﻿using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace Test._0101_0150
{
    [TestClass]
    public class _147_InsertionSortListUnitTest
    {
        _147_InsertionSortListAlg alg = new _147_InsertionSortListAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] head = [4, 2, 1, 3];
            var list = ListNode.BuildListNode(head);
            var node = alg.InsertionSortList(list);
            int[] res = ListNode.GetLinkNodeList(node);
            int[] exp = [1, 2, 3, 4];

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] head = [-1, 5, 3, 4, 0];
            var list = ListNode.BuildListNode(head);
            var node = alg.InsertionSortList(list);
            int[] res = ListNode.GetLinkNodeList(node);
            int[] exp = [-1, 0, 3, 4, 5];

            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
