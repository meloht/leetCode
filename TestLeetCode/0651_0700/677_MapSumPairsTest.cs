using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _677_MapSumPairsTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _677_MapSumPairsAlg.MapSum mapSum = new();
            mapSum.Insert("apple", 3);
            Assert.AreEqual(3, mapSum.Sum("ap"));           // 返回 3 (apple = 3)
            mapSum.Insert("app", 2);
            Assert.AreEqual(5, mapSum.Sum("ap"));
        }

        [TestMethod]
        public void TestCase02()
        {
            _677_MapSumPairsAlg.MapSum mapSum = new();
            mapSum.Insert("apple", 3);
            Assert.AreEqual(3, mapSum.Sum("ap"));           // 返回 3 (apple = 3)
            mapSum.Insert("app", 2);
            mapSum.Insert("apple", 2);
            Assert.AreEqual(4, mapSum.Sum("ap"));
        }

        [TestMethod]
        public void TestCase03()
        {
            _677_MapSumPairsAlg.MapSum mapSum = new();
            mapSum.Insert("apple", 3);
            Assert.AreEqual(3, mapSum.Sum("ap"));           // 返回 3 (apple = 3)
            mapSum.Insert("app", 2);
            Assert.AreEqual(5, mapSum.Sum("ap"));
            mapSum.Insert("apple", 5);
            mapSum.Insert("apple", 1);
            Assert.AreEqual(1, mapSum.Sum("apple"));
        }
    }
}
