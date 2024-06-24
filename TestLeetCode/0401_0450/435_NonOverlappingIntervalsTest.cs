using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _435_NonOverlappingIntervalsTest
    {
        _435_NonOverlappingIntervalsAlg alg = new _435_NonOverlappingIntervalsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] intervals = [[1, 2], [2, 3], [3, 4], [1, 3]];
            int exp = 1;
            int res = alg.EraseOverlapIntervals(intervals);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] intervals = [[1, 2], [1, 2], [1, 2]];
            int exp = 2;
            int res = alg.EraseOverlapIntervals(intervals);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] intervals = [[1, 2], [2, 3]];
            int exp = 0;
            int res = alg.EraseOverlapIntervals(intervals);
            Assert.AreEqual(exp, res);
        }
    }
}
