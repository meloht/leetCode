using System;
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
            List<NodeModel> list = new List<NodeModel>();
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
                    list.Add(new NodeModel { beginX = i, beginY = j, endX = i + 3, endY = j + 3 });
                }

            }

            Dictionary<int, HashSet<int>> rowSet = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> colSet = new Dictionary<int, HashSet<int>>();
            List<Node> listNode = new List<Node>();


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!rowSet.ContainsKey(i))
                        {
                            rowSet.Add(i, new HashSet<int>());
                        }
                        rowSet[i].Add(Convert.ToInt32(board[i][j].ToString()));

                    }
                    else
                    {
                        listNode.Add(new Node() { X = i, Y = j });
                    }

                    if (board[j][i] != '.')
                    {
                        if (!colSet.ContainsKey(i))
                        {
                            colSet.Add(i, new HashSet<int>());
                        }
                        colSet[i].Add(Convert.ToInt32(board[j][i].ToString()));

                    }
                }
            }

            foreach (var node in list)
            {
                for (int i = node.beginX; i < node.endX; i++)
                {
                    for (int j = node.beginY; j < node.endY; j++)
                    {
                        if (board[j][i] == '.')
                        {
                            continue;
                        }
                        node.boxSet.Add(Convert.ToInt32(board[j][i].ToString()));
                    }
                }
                //System.Diagnostics.Debug.WriteLine($"==a:{node.beginX} {node.beginY}==");
                //System.Diagnostics.Debug.WriteLine($"==b:{node.endX} {node.endY}==");
                //Print(node.boxSet);
            }


            //PrintRows(rowSet, "row");

            //PrintRows(colSet, "col");

            InitNodeNums(listNode, rowSet, colSet, list);

            int index = 0;
            bool isOk = true;
            Node nodeData = null;
            while (index < listNode.Count)
            {
                if (isOk)
                {
                    nodeData = listNode[index];
                }

                int num = nodeData.GetNum();

                if (num > 0)
                {
                    nodeData.logSet.Add(num);
                    nodeData.rowSet.Add(num);
                    nodeData.colSet.Add(num);
                    nodeData.boxSet.Add(num);
                    nodeData.Value = num;

                    index++;
                    isOk = true;
                    board[nodeData.X][nodeData.Y] = char.Parse(num.ToString());

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

        private NodeModel GetBox(int i, int j, List<NodeModel> list)
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

        private void InitNodeNums(List<Node> listNode, Dictionary<int, HashSet<int>> rowSet, Dictionary<int, HashSet<int>> colSet, List<NodeModel> list)
        {
            foreach (var node in listNode)
            {
                HashSet<int> col = colSet[node.Y];
                HashSet<int> row = rowSet[node.X];
                HashSet<int> box = GetBox(node.X, node.Y, list).boxSet;
                node.rowSet = row;
                node.colSet = col;
                node.boxSet = box;

                for (int i = 1; i <= 9; i++)
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
            public int Value;
            public HashSet<int> logSet = new HashSet<int>();
            public List<int> NumOps = new List<int>();
            public List<int> OrignalOps = new List<int>();
            public HashSet<int> rowSet = new HashSet<int>();
            public HashSet<int> colSet = new HashSet<int>();
            public HashSet<int> boxSet = new HashSet<int>();

            public int GetNum()
            {
                if (NumOps.Count == 0)
                {
                    return 0;
                }
                int select = 0;
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
                    if (logSet.Contains(num))
                    {
                        continue;
                    }
                    select = num;
                    break;
                }
                if (select > 0)
                {
                    NumOps.Remove(select);
                }
                return select;
            }
            public void ResetOps()
            {
                NumOps.Clear();
                logSet.Clear();
                NumOps.AddRange(OrignalOps);
            }

            public override string ToString()
            {
                return $"x:{X} y:{Y} value:{Value},opValue:{string.Join(",", NumOps)}";
            }
        }

        class NodeModel
        {
            public int beginX;
            public int endX;
            public int beginY;
            public int endY;
            public HashSet<int> boxSet = new HashSet<int>();

            public override string ToString()
            {
                return $"a:[{beginX},{beginY}] b:[{endX},{endY}] boxSet:{string.Join("", boxSet)}";
            }
        }


        private void Print(HashSet<int> list)
        {
            foreach (var item in list)
            {
                System.Diagnostics.Debug.Write($" {item}");
            }
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("=============");
        }
        private void PrintRows(Dictionary<int, HashSet<int>> set, string name)
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
