using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _529_MinesweeperAlg
    {
        int[] dirX = { 0, 1, 0, -1, 1, 1, -1, -1 };
        int[] dirY = { 1, 0, -1, 0, 1, -1, 1, -1 };


        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            int x = click[0], y = click[1];
            if (board[x][y] == 'M')
            {
                // 规则 1
                board[x][y] = 'X';
            }
            else
            {
                dfs(board, x, y);
            }
            return board;

        }

        public void dfs(char[][] board, int x, int y)
        {
            int cnt = 0;
            for (int i = 0; i < 8; ++i)
            {
                int tx = x + dirX[i];
                int ty = y + dirY[i];
                if (tx < 0 || tx >= board.Length || ty < 0 || ty >= board[0].Length)
                {
                    continue;
                }
                // 不用判断 M，因为如果有 M 的话游戏已经结束了
                if (board[tx][ty] == 'M')
                {
                    ++cnt;
                }
            }
            if (cnt > 0)
            {
                // 规则 3
                board[x][y] = (char)(cnt + '0');
            }
            else
            {
                // 规则 2
                board[x][y] = 'B';
                for (int i = 0; i < 8; ++i)
                {
                    int tx = x + dirX[i];
                    int ty = y + dirY[i];
                    // 这里不需要在存在 B 的时候继续扩展，因为 B 之前被点击的时候已经被扩展过了
                    if (tx < 0 || tx >= board.Length || ty < 0 || ty >= board[0].Length || board[tx][ty] != 'E')
                    {
                        continue;
                    }
                    dfs(board, tx, ty);
                }
            }


        }
    }
}
