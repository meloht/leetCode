using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _419_BattleshipsInABoardAlg
    {
        public int CountBattleships(char[][] board)
        {
            int ans = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j]=='X'&&(j == 0 || board[i][j - 1] != 'X') && (i == 0 || board[i - 1][j] != 'X'))
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
