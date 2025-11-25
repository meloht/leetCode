using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1222_QueensThatCanAttackTheKingTest
    {
        _1222_QueensThatCanAttackTheKingAlg alg = new _1222_QueensThatCanAttackTheKingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] queens = [[0, 1], [1, 0], [4, 0], [0, 4], [3, 3], [2, 4]];
            int[] king = [0, 0];
            IList<IList<int>> exp = [[0, 1], [1, 0], [3, 3]];
            IList<IList<int>> res = alg.QueensAttacktheKing(queens,king);
            Assert.IsTrue(Utils.IsSame(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] queens = [[0, 0], [1, 1], [2, 2], [3, 4], [3, 5], [4, 4], [4, 5]];
            int[] king = [3, 3];
            IList<IList<int>> exp = [[2, 2], [3, 4], [4, 4]];
            IList<IList<int>> res = alg.QueensAttacktheKing(queens, king);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
    }
}
