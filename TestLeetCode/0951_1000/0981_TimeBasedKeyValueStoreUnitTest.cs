using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test._0951_1000
{
    [TestClass]
    public class _0981_TimeBasedKeyValueStoreUnitTest
    {

        [TestMethod]
        public void TestCase01()
        {
            _0981_TimeBasedKeyValueStoreAlg.TimeMap timeMap = new _0981_TimeBasedKeyValueStoreAlg.TimeMap();
            timeMap.Set("foo", "bar", 1);  // 存储键 "foo" 和值 "bar" ，时间戳 timestamp = 1   
            Assert.AreEqual(timeMap.Get("foo", 1), "bar");         // 返回 "bar"
            Assert.AreEqual(timeMap.Get("foo", 3), "bar");         // 返回 "bar", 因为在时间戳 3 和时间戳 2 处没有对应 "foo" 的值，所以唯一的值位于时间戳 1 处（即 "bar"） 。
            timeMap.Set("foo", "bar2", 4); // 存储键 "foo" 和值 "bar2" ，时间戳 timestamp = 4  
            Assert.AreEqual(timeMap.Get("foo", 4), "bar2");         // 返回 "bar2"
            Assert.AreEqual(timeMap.Get("foo", 5), "bar2");         // 返回 "bar2"
        }


    }
}
