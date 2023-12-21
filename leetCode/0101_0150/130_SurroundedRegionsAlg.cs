using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _130_SurroundedRegionsAlg
    {
        int iMax = 0;
        int jMax = 0;
        bool[,] dictBorder;
        public void Solve(char[][] board)
        {
            dictBorder = new bool[board.Length, board[0].Length];
            iMax = board.Length - 1;
            jMax = board[0].Length - 1;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (dictBorder[i, j])
                        continue;
                    if (board[i][j] == 'O' && i > 0 && j > 0 && i < iMax && j < jMax)
                    {
                        Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
                        bool bl = IsOver(board, i, j, dict);
                        if (bl)
                        {
                            foreach (var item in dict.Keys)
                            {
                                var jj = dict[item];
                                foreach (var jjj in jj)
                                {
                                    dictBorder[item, jjj] = true;
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in dict.Keys)
                            {
                                var jj = dict[item];
                                foreach (var jjj in jj)
                                {
                                    board[item][jjj] = 'X';
                                }
                            }
                        }
                    }

                }

            }

        }


        private bool IsOver(char[][] board, int i, int j, Dictionary<int, HashSet<int>> dict)
        {
            if (i < 0 || i > iMax || j < 0 || j > jMax)
                return false;
            if (dictBorder[i, j])
                return true;
            if (dict.ContainsKey(i) && dict[i].Contains(j))
                return false;
            if (board[i][j] == 'O' && (i == 0 || i == iMax || j == 0 || j == jMax))
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, new HashSet<int>());
                }
                dict[i].Add(j);
                return true;
            }
            else if (board[i][j] == 'X')
            {
                return false;
            }
            else if (board[i][j] == 'O' && i > 0 && i < iMax && j > 0 && j < jMax)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, new HashSet<int>());
                }
                dict[i].Add(j);
                bool blUp = IsOver(board, i - 1, j, dict);
                bool blDown = IsOver(board, i + 1, j, dict);
                bool blLeft = IsOver(board, i, j - 1, dict);
                bool blRight = IsOver(board, i, j + 1, dict);

                if (blUp || blDown || blLeft || blRight)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
