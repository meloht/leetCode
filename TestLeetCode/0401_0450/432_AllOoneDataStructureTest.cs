using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0401_0450._432_AllOoneDataStructureAlg;

namespace Test._0401_0450
{
    [TestClass]
    public class _432_AllOoneDataStructureTest
    {
        [TestMethod]
        public void TestCase01()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("hello");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("hello", allOne.GetMinKey()); // 返回 "hello"
            allOne.Inc("leet");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("leet", allOne.GetMinKey()); // 返回 "leet"
        }

        [TestMethod]
        public void TestCase02()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("goodbye");
            allOne.Inc("hello");
            allOne.Inc("hello");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("leet");
            allOne.Dec("hello");
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("code");
            Assert.AreEqual("leet", allOne.GetMinKey()); // 返回 "hello"
          
        }
    }
}
