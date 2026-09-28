using System;
using System.Collections.Generic;
using System.Text;
using static leetCode._1251_1300._1286_iterator_for_combination;

namespace Test._1251_1300
{
    [TestClass]
    public class _1286_iterator_for_combination_test
    {
        [TestMethod]
        public void Test01()
        {
            CombinationIterator iterator = new CombinationIterator("abc", 2); // 创建迭代器 iterator
            Assert.AreEqual("ab", iterator.Next()); // 返回 "ab"
            Assert.AreEqual(true, iterator.HasNext()); // 返回 true
            Assert.AreEqual("ac", iterator.Next()); // 返回 "ac"
            Assert.AreEqual(true, iterator.HasNext()); // 返回 true
            Assert.AreEqual("bc", iterator.Next()); // 返回 "bc"
            Assert.AreEqual(false, iterator.HasNext()); // 返回 false
        }
    }
}
