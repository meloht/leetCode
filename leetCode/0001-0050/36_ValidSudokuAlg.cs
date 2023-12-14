using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _36_ValidSudokuAlg
    {
        public bool IsValidSudoku(char[][] board)
        {
            List<NodeModel> list = new List<NodeModel>();
            list.Add(new NodeModel { beginX = 0, beginY = 0, endX = 3, endY = 3 });
            list.Add(new NodeModel { beginX = 0, beginY = 3, endX = 3, endY = 6 });
            list.Add(new NodeModel { beginX = 0, beginY = 6, endX = 3, endY = 9 });
            list.Add(new NodeModel { beginX = 3, beginY = 0, endX = 6, endY = 3 });
            list.Add(new NodeModel { beginX = 3, beginY = 3, endX = 6, endY = 6 });
            list.Add(new NodeModel { beginX = 3, beginY = 6, endX = 6, endY = 9 });
            list.Add(new NodeModel { beginX = 6, beginY = 0, endX = 9, endY = 3 });
            list.Add(new NodeModel { beginX = 6, beginY = 3, endX = 9, endY = 6 });
            list.Add(new NodeModel { beginX = 6, beginY = 6, endX = 9, endY = 9 });

            HashSet<char> hashSetX = new HashSet<char>();
            HashSet<char> hashSetY = new HashSet<char>();
            foreach (var node in list)
            {
                hashSetX.Clear();
                for (int i = node.beginX; i < node.endX; i++)
                {
                    for (int j = node.beginY; j < node.endY; j++)
                    {
                        if (board[i][j] == '.') 
                        {
                            continue;
                        }
                        if (hashSetX.Contains(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            hashSetX.Add(board[i][j]);
                        }
                    }
                }
            }
            for (int i = 0; i < board.Length; i++)
            {
                hashSetX.Clear();
                hashSetY.Clear();
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (hashSetX.Contains(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            hashSetX.Add(board[i][j]);
                        }

                    }

                    if (board[j][i] != '.')
                    {
                        if (hashSetY.Contains(board[j][i]))
                        {
                            return false;
                        }
                        else
                        {
                            hashSetY.Add(board[j][i]);
                        }
                    }

                }
             
            }
            return true;
        }


        class NodeModel
        {
            public int beginX;
            public int endX;
            public int beginY;
            public int endY;
        }


        public bool IsValidSudoku1(char[][] board)
        {
            int[,] rows = new int[9, 9];
            int[,] columns = new int[9, 9];
            int[,,] subboxes = new int[3, 3, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char c = board[i][j];
                    if (c != '.')
                    {
                        int index = c - '0' - 1;
                        rows[i, index]++;
                        columns[j, index]++;
                        subboxes[i / 3, j / 3, index]++;
                        if (rows[i, index] > 1 || columns[j, index] > 1 || subboxes[i / 3, j / 3, index] > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }



}
