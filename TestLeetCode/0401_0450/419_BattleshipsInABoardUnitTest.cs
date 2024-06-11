using leetCode._0401_0450;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _419_BattleshipsInABoardUnitTest
    {
        _419_BattleshipsInABoardAlg alg = new _419_BattleshipsInABoardAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [['X', '.', '.', 'X'], ['.', '.', '.', 'X'], ['.', '.', '.', 'X']];
            int exp = 2;
            int res = alg.CountBattleships(board);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [['.']];
            int exp = 0;
            int res = alg.CountBattleships(board);
            Assert.AreEqual(exp, res);
        }
    }
}
