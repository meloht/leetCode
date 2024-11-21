using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0601_0650._622_DesignCircularQueueAlg;

namespace Test._0601_0650
{
    [TestClass]
    public class _622_DesignCircularQueueTest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyCircularQueue circularQueue = new MyCircularQueue(3); // 设置长度为 3
            Assert.AreEqual(true, circularQueue.EnQueue(1));  // 返回 true
            Assert.AreEqual(true, circularQueue.EnQueue(2));  // 返回 true
            Assert.AreEqual(true, circularQueue.EnQueue(3));  // 返回 true
            Assert.AreEqual(false, circularQueue.EnQueue(4));  // 返回 false，队列已满
            Assert.AreEqual(3, circularQueue.Rear());  // 返回 3
            Assert.AreEqual(true, circularQueue.IsFull());  // 返回 true
            Assert.AreEqual(true, circularQueue.DeQueue());  // 返回 true
            Assert.AreEqual(true, circularQueue.EnQueue(4));  // 返回 true
            Assert.AreEqual(4, circularQueue.Rear());  // 返回 4
        }

        [TestMethod]
        public void TestCase02()
        {
            MyCircularQueue circularQueue = new MyCircularQueue(8); 
            Assert.AreEqual(true, circularQueue.EnQueue(3));  
            Assert.AreEqual(true, circularQueue.EnQueue(9));  
            Assert.AreEqual(true, circularQueue.EnQueue(5));  
            Assert.AreEqual(true, circularQueue.EnQueue(0));
            Assert.AreEqual(true, circularQueue.DeQueue());
            Assert.AreEqual(true, circularQueue.DeQueue());
            Assert.AreEqual(false, circularQueue.IsEmpty());
            Assert.AreEqual(false, circularQueue.IsEmpty());
            Assert.AreEqual(0, circularQueue.Rear());
            Assert.AreEqual(0, circularQueue.Rear());
            Assert.AreEqual(true, circularQueue.DeQueue());
           
        }
    }
}
