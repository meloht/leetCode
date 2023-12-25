using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0101_0150._146_LRUCacheAlg;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _146_LRUCacheUnitTest
    {


        [TestMethod]
        public void TestCase01()
        {
            _146_LRUCacheAlg.LRUCache alg = new LRUCache(2);
            alg.Put(1, 1);
            alg.Put(2, 2);
            Assert.AreEqual(1, alg.Get(1));
            alg.Put(3, 3);
            Assert.AreEqual(-1, alg.Get(2));
            alg.Put(4, 4);
            Assert.AreEqual(-1, alg.Get(1));
            Assert.AreEqual(3, alg.Get(3));
            Assert.AreEqual(4, alg.Get(4));
        }


        [TestMethod]
        public void TestCase02()
        {
            _146_LRUCacheAlg.LRUCache alg = new LRUCache(1);
            alg.Put(2, 1);

            Assert.AreEqual(1, alg.Get(2));
            alg.Put(3, 2);
            Assert.AreEqual(-1, alg.Get(2));

            Assert.AreEqual(2, alg.Get(3));

        }
    }
}
