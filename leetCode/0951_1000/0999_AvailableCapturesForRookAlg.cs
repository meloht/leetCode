using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0999_AvailableCapturesForRookAlg
    {
        public int NumRookCaptures(char[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;
            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] != 'R')
                    {
                        continue;
                    }


                    ans += GetColNum(i + 1, m, j, board);
                    ans += GetColNum1(0, i, j, board);
                    ans += GetRowNum1(0, j, i, board);
                    ans += GetRowNum(j + 1, n, i, board);
                    return ans;

                }
            }

            return 0;
        }
        private int GetColNum(int begin, int end, int j, char[][] board)
        {
            for (int k = begin; k < end; k++)
            {
                if (board[k][j] == 'B')
                {
                    break;
                }
                if (board[k][j] == 'p')
                {
                    return 1;
                }
            }
            return 0;
        }
        private int GetColNum1(int begin, int end, int j, char[][] board)
        {
            for (int k = end - 1; k >= begin; k--)
            {
                if (board[k][j] == 'B')
                {
                    break;
                }
                if (board[k][j] == 'p')
                {
                    return 1;
                }
            }
            return 0;
        }
        private int GetRowNum(int begin, int end, int i, char[][] board)
        {
            for (int k = begin; k < end; k++)
            {
                if (board[i][k] == 'B')
                {
                    break;
                }
                if (board[i][k] == 'p')
                {
                    return 1;
                }
            }
            return 0;
        }
        private int GetRowNum1(int begin, int end, int i, char[][] board)
        {
            for (int k = end - 1; k >= begin; k--)
            {
                if (board[i][k] == 'B')
                {
                    break;
                }
                if (board[i][k] == 'p')
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
