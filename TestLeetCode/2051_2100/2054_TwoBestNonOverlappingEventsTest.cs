using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2051_2100
{
    [TestClass]
    public class _2054_TwoBestNonOverlappingEventsTest
    {
        _2054_TwoBestNonOverlappingEventsAlg alg = new _2054_TwoBestNonOverlappingEventsAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] events = [[1, 3, 2], [4, 5, 2], [2, 4, 3]];
            int exp = 4;
            int res = alg.MaxTwoEvents(events);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[][] events = [[1, 3, 2], [4, 5, 2], [1, 5, 5]];
            int exp = 5;
            int res = alg.MaxTwoEvents(events);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[][] events = [[1, 5, 3], [1, 5, 1], [6, 6, 5]];
            int exp = 8;
            int res = alg.MaxTwoEvents(events);
            Assert.AreEqual(exp, res);
        }
    }
}
