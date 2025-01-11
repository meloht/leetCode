using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._707_DesignLinkedListAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _707_DesignLinkedListTest
    {
        [TestMethod]
        public void TestCase01()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(0, 4);
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // 链表变为 1->2->3
            Assert.AreEqual(2, myLinkedList.Get(1));              // 返回 2
            myLinkedList.DeleteAtIndex(1);    // 现在，链表变为 1->3
            Assert.AreEqual(3, myLinkedList.Get(1));
        }

        [TestMethod]
        public void TestCase02()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtIndex(3, 0);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.AddAtHead(6);
            myLinkedList.AddAtTail(4);
            Assert.AreEqual(4, myLinkedList.Get(4));

        }

        [TestMethod]
        public void TestCase03()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtIndex(0, 10);
            myLinkedList.AddAtIndex(0, 20);
            myLinkedList.AddAtIndex(1, 30);

            Assert.AreEqual(20, myLinkedList.Get(0));

        }

        [TestMethod]
        public void TestCase04()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(3, 2);

        }

        [TestMethod]
        public void TestCase05()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(2);
            myLinkedList.DeleteAtIndex(1);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(5);
            myLinkedList.AddAtTail(5);
            Assert.AreEqual(2, myLinkedList.Get(5));
            myLinkedList.DeleteAtIndex(6);
            myLinkedList.DeleteAtIndex(4);

        }

        [TestMethod]
        public void TestCase06()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(4);
            Assert.AreEqual(-1, myLinkedList.Get(1));
           
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(5);
            myLinkedList.DeleteAtIndex(3);
            myLinkedList.AddAtHead(7);
            myLinkedList.Get(3);
            myLinkedList.Get(3);
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(4);

        }

        [TestMethod]
        public void TestCase07()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtIndex(1, 0);
            Assert.AreEqual(-1, myLinkedList.Get(0));

           

        }
    }
}
