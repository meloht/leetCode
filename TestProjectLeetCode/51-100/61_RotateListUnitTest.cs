using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _61_RotateListUnitTest
    {
        _61_RotateListAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _61_RotateListAlg();
        }
        private bool IsEqual(int[] res, ListNode node)
        {
            ListNode currentNode = node;
            
            List<int> list=new List<int>();
            while (currentNode != null)
            {
                list.Add(currentNode.val);
                currentNode = currentNode.next;
               
            }
            bool bl = list.ToArray().SequenceEqual(res);
            return bl;
        }

        [TestMethod]
        public void TestCase01()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            var nodeResult = alg.RotateRight(node1, 2);
            int[] res = { 4, 5, 1, 2, 3 };
            bool bl = IsEqual(res, nodeResult);
            Assert.AreEqual(true, bl);
        }


        [TestMethod]
        public void TestCase02()
        {
            ListNode node1 = new ListNode(0);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(2);

            node1.next = node2;
            node2.next = node3;

            var nodeResult = alg.RotateRight(node1, 4);
            int[] res = { 2,0,1 };
            bool bl = IsEqual(res, nodeResult);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;

            var nodeResult = alg.RotateRight(node1, 2000000000);
            //int[] res = { 2, 0, 1 };
            //bool bl = IsEqual(res, nodeResult);
            //Assert.AreEqual(true, bl);
        }

    }
}
