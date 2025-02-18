using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._2051_2100._2080_RangeFrequencyQueriesAlg;

namespace Test._2051_2100
{
    [TestClass]
    public class _2080_RangeFrequencyQueriesTest
    {
        [TestMethod]
        public void TestCase01()
        {
            RangeFreqQuery rangeFreqQuery = new RangeFreqQuery([12, 33, 4, 56, 22, 2, 34, 33, 22, 12, 34, 56]);
            Assert.AreEqual(1, rangeFreqQuery.Query(1, 2, 4)); // 返回 1 。4 在子数组 [33, 4] 中出现 1 次。
            Assert.AreEqual(2, rangeFreqQuery.Query(0, 11, 33)); // 返回 2 。33 在整个子数组中出现 2 次。
        }

        [TestMethod]
        public void TestCase02()
        {
            RangeFreqQuery rangeFreqQuery = new RangeFreqQuery([1, 1, 1, 2, 2]);
            Assert.AreEqual(0, rangeFreqQuery.Query(0, 1, 2)); 
            Assert.AreEqual(3, rangeFreqQuery.Query(0, 2, 1));
            Assert.AreEqual(1, rangeFreqQuery.Query(3, 3, 2));
            Assert.AreEqual(1, rangeFreqQuery.Query(2, 2, 1));
        }
    }
}
