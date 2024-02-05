using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _289_GameOfLifeAlg
    {
        public void GameOfLife(int[][] board)
        {
            int n = board.Length;
            int m = board[0].Length;
            int[,] op = { { 0, 1 }, { 0, -1 }, { -1, 0 }, { 1, 0 }, { 1, 1 }, { 1, -1 }, { -1, 1 }, { -1, -1 } };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    int life = 0;
                    int dead = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ii = i + op[k, 0];
                        int jj = j + op[k, 1];
                        if (ii >= 0 && ii < n && jj >= 0 && jj < m)
                        {
                            if (board[ii][jj] == 0 || board[ii][jj] == -1) // 0->1  -1 is dead  ,1->0 2 is life
                            {
                                dead++;
                            }
                            else
                            {
                                life++;
                            }
                        }
                    }
                    if (board[i][j] == 0 || board[i][j] == -1)
                    {
                        if (life == 3)
                        {
                            board[i][j] = -1;
                        }
                    }
                    else
                    {
                        if (life < 2)
                        {
                            board[i][j] = 2;
                        }
                        else if (life == 2 || life == 3)
                        {
                            if (board[i][j] == 2)
                            {
                                board[i][j] = 1;
                            }
                        }
                        else if (life > 3)
                        {
                            board[i][j] = 2;
                        }
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == 2)
                    {
                        board[i][j] = 0;
                    }
                    else if (board[i][j] == -1)
                    {
                        board[i][j] = 1;
                    }
                }
            }


        }
    }
}
