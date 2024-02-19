using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _947_MostStonesRemovedWithSameRowOrColumnUnitTest
    {
        _947_MostStonesRemovedWithSameRowOrColumnAlg alg = new _947_MostStonesRemovedWithSameRowOrColumnAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] stones = [[0, 0], [0, 1], [1, 0], [1, 2], [2, 1], [2, 2]];
            int exp = 5;
            int res = alg.RemoveStones(stones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] stones = [[0, 0], [0, 2], [1, 1], [2, 0], [2, 2]];
            int exp = 3;
            int res = alg.RemoveStones(stones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] stones = [[0, 0]];
            int exp = 0;
            int res = alg.RemoveStones(stones);
            Assert.AreEqual(exp, res);
        }
    }
}
