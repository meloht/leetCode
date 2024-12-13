using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test._0601_0650
{
    [TestClass]
    public class _641_DesignCircularDequeTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _641_DesignCircularDequeAlg.MyCircularDeque circularDeque = new _641_DesignCircularDequeAlg.MyCircularDeque(3); // 设置容量大小为3
            Assert.AreEqual(true, circularDeque.InsertLast(1));                    // 返回 true
            Assert.AreEqual(true, circularDeque.InsertLast(2));                    // 返回 true
            Assert.AreEqual(true, circularDeque.InsertFront(3));                   // 返回 true
            Assert.AreEqual(false, circularDeque.InsertFront(4));                   // 已经满了，返回 false
            Assert.AreEqual(2, circularDeque.GetRear());                // 返回 2
            Assert.AreEqual(true, circularDeque.IsFull());                     // 返回 true
            Assert.AreEqual(true, circularDeque.DeleteLast());                 // 返回 true
            Assert.AreEqual(true, circularDeque.InsertFront(4));                   // 返回 true
            Assert.AreEqual(4, circularDeque.GetFront());				// 返回 4
        }
    }
}
