using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1951_2000
{
    public class _1958_CheckIfMoveIsLegalAlg
    {
        public bool CheckMove(char[][] board, int rMove, int cMove, char color)
        {
            int n = board.Length;
            int m = board[0].Length;


            int[][] dirs = [[1, 0], [1, 1], [0, 1], [-1, 1], [-1, 0], [-1, -1], [0, -1], [1, -1]];

            foreach (int[] dir in dirs)
            {
                int x = rMove + dir[0];
                int y = cMove + dir[1];
                if (x < 0 || x >= n || y < 0 || y >= m || board[x][y] == '.' || board[x][y] == color)
                {
                    continue;
                }
                while (true)
                {
                    x += dir[0];
                    y += dir[1];
                    if (x < 0 || x >= n || y < 0 || y >= m || board[x][y] == '.')
                    {
                        break;
                    }
                    if (board[x][y] == color)
                    {
                        return true;
                    }
                }
            }


            return false;
        }





    }
}
