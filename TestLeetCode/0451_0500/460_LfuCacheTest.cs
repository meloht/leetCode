using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0451_0500._460_LfuCacheAlg;

namespace Test._0451_0500
{
    [TestClass]
    public class _460_LfuCacheTest
    {
        [TestMethod]
        public void TestCase01()
        {
            LFUCache lfu = new LFUCache(2);
            lfu.Put(1, 1);   // cache=[1,_], cnt(1)=1
            lfu.Put(2, 2);   // cache=[2,1], cnt(2)=1, cnt(1)=1
            int res = lfu.Get(1);      // 返回 1
            Assert.AreEqual(1, res);
            // cache=[1,2], cnt(2)=1, cnt(1)=2
            lfu.Put(3, 3);   // 去除键 2 ，因为 cnt(2)=1 ，使用计数最小
                             // cache=[3,1], cnt(3)=1, cnt(1)=2
            res = lfu.Get(2);      // 返回 -1（未找到）
            Assert.AreEqual(-1, res);
            res = lfu.Get(3);      // 返回 3
            Assert.AreEqual(3, res); // cache=[3,1], cnt(3)=2, cnt(1)=2

            lfu.Put(4, 4);   // 去除键 1 ，1 和 3 的 cnt 相同，但 1 最久未使用
                             // cache=[4,3], cnt(4)=1, cnt(3)=2
            res = lfu.Get(1);      // 返回 -1（未找到）
            Assert.AreEqual(-1, res);
            res = lfu.Get(3);      // 返回 3
            Assert.AreEqual(3, res);                // cache=[3,4], cnt(4)=1, cnt(3)=3
            res = lfu.Get(4);      // 返回 4  // cache=[3,4], cnt(4)=2, cnt(3)=3
            Assert.AreEqual(4, res);
        }
    }
}
