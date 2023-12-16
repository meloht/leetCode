using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{

    [TestClass]
    public class _82_RemoveDuplicatesFromSortedListIIUnitTest
    {
        _82_RemoveDuplicatesFromSortedListIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _82_RemoveDuplicatesFromSortedListIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(3);
            ListNode node5 = new ListNode(4);
            ListNode node6 = new ListNode(4);
            ListNode node7 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;

            var res = alg.DeleteDuplicates(node1);
            int[] arr = { 1, 2, 5 };
            List<int> list = new List<int>();
            ListNode node = res;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(1);
            ListNode node4 = new ListNode(2);
            ListNode node5 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var res = alg.DeleteDuplicates(node1);
            int[] arr = { 2, 3 };
            List<int> list = new List<int>();
            ListNode node = res;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(2);


            node1.next = node2;
            node2.next = node3;


            var res = alg.DeleteDuplicates(node1);
            int[] arr = { 1 };
            List<int> list = new List<int>();
            ListNode node = res;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());

            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);


            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            var res = alg.DeleteDuplicates(node1);
            int[] arr = { 1,2,3,4 };
            List<int> list = new List<int>();
            ListNode node = res;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());

            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase05()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(2);
            ListNode node4 = new ListNode(2);


            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            var res = alg.DeleteDuplicates(node1);
            int[] arr = {  };
            List<int> list = new List<int>();
            ListNode node = res;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());

            Assert.AreEqual(true, bl);
        }
    }

}
