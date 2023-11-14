using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _37_SudokuSolverUnitTest
    {
        _37_SudokuSolverAlg alg = new _37_SudokuSolverAlg();

        [TestMethod]
        public void TestCase01()
        {

            char[][] board =
{ new []{'5', '3', '.', '.', '7', '.', '.', '.', '.' }
, new []{'6', '.', '.', '1', '9', '5', '.', '.', '.' }
, new []{'.', '9', '8', '.', '.', '.', '.', '6', '.'}
, new []{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
, new []{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
, new []{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
, new []{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
, new []{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
, new []{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
            alg.SolveSudoku(board);

            char[][] board2 =
{ new []{ '5', '3', '4', '6', '7', '8', '9', '1', '2' }
, new []{ '6', '7', '2', '1', '9', '5', '3', '4', '8' }
, new []{ '1', '9', '8', '3', '4', '2', '5', '6', '7' }
, new []{ '8', '5', '9', '7', '6', '1', '4', '2', '3' }
, new []{ '4', '2', '6', '8', '5', '3', '7', '9', '1' }
, new []{ '7', '1', '3', '9', '2', '4', '8', '5', '6' }
, new []{ '9', '6', '1', '5', '3', '7', '2', '8', '4' }
, new []{ '2', '8', '7', '4', '1', '9', '6', '3', '5' }
, new []{'3','4','5','2','8','6','1','7','9'}};


            bool bl = IsSame(board, board2);
            Assert.IsTrue(bl);

        }

        private bool IsSame(char[][] board, char[][] board2)
        {
            for (int i = 0; i < board.Length; i++)
            {
                var item = board[i];
                var item2 = board2[i];
                if (!item.SequenceEqual(item2))
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void TestCase02()
        {
            for (int i = 0; i <=6; i += 3)
            {
                for (int j = 0; j <=6; j += 3)
                {
                    System.Diagnostics.Debug.WriteLine($"{i},{j}");
                    System.Diagnostics.Debug.WriteLine($"{i+3},{j+3}");
                    System.Diagnostics.Debug.WriteLine("-------------");
                }
               
            }
            Assert.IsTrue(true);
        }

    }



}
