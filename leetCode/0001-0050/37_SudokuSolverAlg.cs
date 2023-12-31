﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _37_SudokuSolverAlg
    {
        public void SolveSudoku(char[][] board)
        {
            List<BoxModel> boxList = new List<BoxModel>();
            //list.Add(new NodeModel { beginX = 0, beginY = 0, endX = 3, endY = 3 });
            //list.Add(new NodeModel { beginX = 0, beginY = 3, endX = 3, endY = 6 });
            //list.Add(new NodeModel { beginX = 0, beginY = 6, endX = 3, endY = 9 });
            //list.Add(new NodeModel { beginX = 3, beginY = 0, endX = 6, endY = 3 });
            //list.Add(new NodeModel { beginX = 3, beginY = 3, endX = 6, endY = 6 });
            //list.Add(new NodeModel { beginX = 3, beginY = 6, endX = 6, endY = 9 });
            //list.Add(new NodeModel { beginX = 6, beginY = 0, endX = 9, endY = 3 });
            //list.Add(new NodeModel { beginX = 6, beginY = 3, endX = 9, endY = 6 });
            //list.Add(new NodeModel { beginX = 6, beginY = 6, endX = 9, endY = 9 });
            for (int i = 0; i <= 6; i += 3)
            {
                for (int j = 0; j <= 6; j += 3)
                {
                    boxList.Add(new BoxModel { beginX = i, beginY = j, endX = i + 3, endY = j + 3 });
                }

            }

            Dictionary<int, HashSet<char>> rowSet = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> colSet = new Dictionary<int, HashSet<char>>();
            List<Node> listNode = new List<Node>();


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!rowSet.ContainsKey(i))
                        {
                            rowSet.Add(i, new HashSet<char>());
                        }
                        rowSet[i].Add(board[i][j]);

                    }
                    else
                    {
                        listNode.Add(new Node() { X = i, Y = j });
                    }

                    if (board[j][i] != '.')
                    {
                        if (!colSet.ContainsKey(i))
                        {
                            colSet.Add(i, new HashSet<char>());
                        }
                        colSet[i].Add(board[j][i]);

                    }
                }
            }

            foreach (var node in boxList)
            {
                for (int i = node.beginX; i < node.endX; i++)
                {
                    for (int j = node.beginY; j < node.endY; j++)
                    {
                        if (board[j][i] == '.')
                        {
                            continue;
                        }
                        node.boxSet.Add(board[j][i]);
                    }
                }
                //System.Diagnostics.Debug.WriteLine($"==a:{node.beginX} {node.beginY}==");
                //System.Diagnostics.Debug.WriteLine($"==b:{node.endX} {node.endY}==");
                //Print(node.boxSet);
            }


            //PrintRows(rowSet, "row");

            //PrintRows(colSet, "col");

            InitNodeNums(listNode, rowSet, colSet, boxList);

            int index = 0;
            bool isOk = true;
            Node nodeData = null;
            while (index < listNode.Count)
            {
                if (isOk)
                {
                    nodeData = listNode[index];
                }

                char num = nodeData.GetNum();

                if (num != '0')
                {
                    nodeData.rowSet.Add(num);
                    nodeData.colSet.Add(num);
                    nodeData.boxSet.Add(num);
                    nodeData.Value = num;

                    index++;
                    isOk = true;
                    board[nodeData.X][nodeData.Y] = num;

                    //PrintBorad(board, nodeData);
                }
                else
                {
                    if (index > 0)
                    {
                        nodeData.ResetOps();
                        index--;
                        isOk = false;
                        nodeData = listNode[index];

                        nodeData.rowSet.Remove(nodeData.Value);
                        nodeData.colSet.Remove(nodeData.Value);
                        nodeData.boxSet.Remove(nodeData.Value);

                        board[nodeData.X][nodeData.Y] = '.';
                    }
                    else
                    {
                        break;
                    }


                }
            }
        }

        private BoxModel GetBox(int i, int j, List<BoxModel> list)
        {
            foreach (var node in list)
            {
                if (i >= node.beginY && i < node.endY && j >= node.beginX && j < node.endX)
                {
                    return node;
                }
            }
            return null;
        }

        private void InitNodeNums(List<Node> listNode, Dictionary<int, HashSet<char>> rowSet, Dictionary<int, HashSet<char>> colSet, List<BoxModel> list)
        {
            char[] chars = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var node in listNode)
            {
                HashSet<char> col = colSet[node.Y];
                HashSet<char> row = rowSet[node.X];
                HashSet<char> box = GetBox(node.X, node.Y, list).boxSet;
                node.rowSet = row;
                node.colSet = col;
                node.boxSet = box;

                foreach (var i in chars)
                {
                    if (col.Contains(i))
                    {
                        continue;
                    }
                    if (row.Contains(i))
                    {
                        continue;
                    }
                    if (box.Contains(i))
                    {
                        continue;
                    }
                    node.NumOps.Add(i);
                    node.OrignalOps.Add(i);
                }
            }
        }


        class Node
        {
            public int X;
            public int Y;
            public char Value;
            public List<char> NumOps = new List<char>();
            public List<char> OrignalOps = new List<char>();
            public HashSet<char> rowSet = new HashSet<char>();
            public HashSet<char> colSet = new HashSet<char>();
            public HashSet<char> boxSet = new HashSet<char>();

            public char GetNum()
            {
                if (NumOps.Count == 0)
                {
                    return '0';
                }
                char select = '0';
                foreach (var num in NumOps)
                {
                    if (rowSet.Contains(num))
                    {
                        continue;
                    }
                    if (colSet.Contains(num))
                    {
                        continue;
                    }
                    if (boxSet.Contains(num))
                    {
                        continue;
                    }
                    select = num;
                    break;
                }
                if (select != '0')
                {
                    NumOps.Remove(select);
                }
                return select;
            }
            public void ResetOps()
            {
                NumOps.Clear();
                NumOps.AddRange(OrignalOps);
            }

            public override string ToString()
            {
                return $"x:{X} y:{Y} value:{Value},opValue:{string.Join(",", NumOps)}";
            }
        }

        class BoxModel
        {
            public int beginX;
            public int endX;
            public int beginY;
            public int endY;
            public HashSet<char> boxSet = new HashSet<char>();

            public override string ToString()
            {
                return $"a:[{beginX},{beginY}] b:[{endX},{endY}] boxSet:{string.Join("", boxSet)}";
            }
        }


        private void Print(HashSet<char> list)
        {
            foreach (var item in list)
            {
                System.Diagnostics.Debug.Write($" {item}");
            }
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("=============");
        }
        private void PrintRows(Dictionary<int, HashSet<char>> set, string name)
        {
            foreach (var item in set.Keys)
            {
                System.Diagnostics.Debug.WriteLine($"=={name}:{item}==");
                Print(set[item]);
            }
        }
        private void PrintBorad(char[][] board, Node node)
        {
            System.Diagnostics.Debug.WriteLine($"======board==x:{node.X} y:{node.Y} value:{node.Value}=====");
            foreach (var item in board)
            {
                foreach (var b in item)
                {
                    System.Diagnostics.Debug.Write($" {b.ToString()}");
                }
                System.Diagnostics.Debug.WriteLine("");
            }
            System.Diagnostics.Debug.WriteLine("=============");
        }

    }
}
