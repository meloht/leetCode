using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2225_FindPlayersWithZeroOrOneLossesUnitTest
    {
        _2225_FindPlayersWithZeroOrOneLossesAlg alg = new _2225_FindPlayersWithZeroOrOneLossesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] matches = [[1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]];
            IList<IList<int>> exp = [[1, 2, 10], [4, 5, 7, 8]];
            IList<IList<int>> res = alg.FindWinners(matches);
            bool bl = Utils.IsSameList(exp, res);
            Assert.AreEqual(bl, true);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] matches = [[2, 3], [1, 3], [5, 4], [6, 4]];
            IList<IList<int>> exp = [[1, 2, 5, 6], []];
            IList<IList<int>> res = alg.FindWinners(matches);
            bool bl = Utils.IsSameList(exp, res);
            Assert.AreEqual(bl, true);
        }
    }
}
