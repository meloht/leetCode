using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0201_0250._232_ImplementQueueUsingStacksAlg;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _232_ImplementQueueUsingStacksUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _232_ImplementQueueUsingStacksAlg.MyQueue myQueue = new _232_ImplementQueueUsingStacksAlg.MyQueue();

            myQueue.Push(1); // queue is: [1]
            myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            Assert.AreEqual(1, myQueue.Peek()); // return 1
            Assert.AreEqual(1, myQueue.Pop()); // return 1, queue is [2]
            Assert.AreEqual(false, myQueue.Empty()); // return false
        }
    }
}
