using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._706_DesignHashmapAlg;

namespace Test._0701_0750
{
    [TestClass]
    public class _706_DesignHashmapUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(1, 1); // myHashMap 现在为 [[1,1]]
            myHashMap.Put(2, 2); // myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(1, myHashMap.Get(1));    // 返回 1 ，myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(-1, myHashMap.Get(3));    // 返回 -1（未找到），myHashMap 现在为 [[1,1], [2,2]]
            myHashMap.Put(2, 1); // myHashMap 现在为 [[1,1], [2,1]]（更新已有的值）
            Assert.AreEqual(1, myHashMap.Get(2));    // 返回 1 ，myHashMap 现在为 [[1,1], [2,1]]
            myHashMap.Remove(2); // 删除键为 2 的数据，myHashMap 现在为 [[1,1]]
            Assert.AreEqual(-1, myHashMap.Get(2));    // 返回 -1（未找到），myHashMap 现在为 [[1,1]]
        }

        [TestMethod]
        public void TestCase02()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(769, 1); // myHashMap 现在为 [[1,1]]
            myHashMap.Put(20000, 2); // myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(1, myHashMap.Get(769));    // 返回 1 ，myHashMap 现在为 [[1,1], [2,2]]
            Assert.AreEqual(-1, myHashMap.Get(3));    // 返回 -1（未找到），myHashMap 现在为 [[1,1], [2,2]]
            myHashMap.Put(2, 1); // myHashMap 现在为 [[1,1], [2,1]]（更新已有的值）
            Assert.AreEqual(1, myHashMap.Get(2));    // 返回 1 ，myHashMap 现在为 [[1,1], [2,1]]
            myHashMap.Remove(2); // 删除键为 2 的数据，myHashMap 现在为 [[1,1]]
            myHashMap.Remove(769);
            myHashMap.Remove(20000);
            Assert.AreEqual(-1, myHashMap.Get(2));    // 返回 -1（未找到），myHashMap 现在为 [[1,1]]
            Assert.AreEqual(-1, myHashMap.Get(20000));
            Assert.AreEqual(-1, myHashMap.Get(769));
        }
    }
}
