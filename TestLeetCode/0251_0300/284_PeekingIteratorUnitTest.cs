using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test._0251_0300
{
    [TestClass]
    public class _284_PeekingIteratorUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            List<int> nums = [1, 2, 3];
            _284_PeekingIteratorAlg.PeekingIterator peekingIterator = new _284_PeekingIteratorAlg.PeekingIterator(nums.GetEnumerator());
            Assert.AreEqual(1, peekingIterator.Next());    // 返回 1 ，指针移动到下一个元素 [1,2,3]
            Assert.AreEqual(2, peekingIterator.Peek());    // 返回 2 ，指针未发生移动 [1,2,3]
            Assert.AreEqual(2, peekingIterator.Next());    // 返回 2 ，指针移动到下一个元素 [1,2,3]
            Assert.AreEqual(3, peekingIterator.Next());    // 返回 3 ，指针移动到下一个元素 [1,2,3]
            Assert.AreEqual(false, peekingIterator.HasNext()); // 返回 False
        }
    }
}
