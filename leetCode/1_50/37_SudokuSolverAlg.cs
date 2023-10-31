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
            list.Add(new NodeModel { beginX = 0, beginY = 0, endX = 3, endY = 3 });
            list.Add(new NodeModel { beginX = 0, beginY = 3, endX = 3, endY = 6 });
            list.Add(new NodeModel { beginX = 0, beginY = 6, endX = 3, endY = 9 });
            list.Add(new NodeModel { beginX = 3, beginY = 0, endX = 6, endY = 3 });
            list.Add(new NodeModel { beginX = 3, beginY = 3, endX = 6, endY = 6 });
            list.Add(new NodeModel { beginX = 3, beginY = 6, endX = 6, endY = 9 });
            list.Add(new NodeModel { beginX = 6, beginY = 0, endX = 9, endY = 3 });
            list.Add(new NodeModel { beginX = 6, beginY = 3, endX = 9, endY = 6 });
            list.Add(new NodeModel { beginX = 6, beginY = 6, endX = 9, endY = 9 });

            Dictionary<int, HashSet<int>> rowSet = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> colSet = new Dictionary<int, HashSet<int>>();
            List<Node> listNode = new List<Node>();
            Dictionary<int, Dictionary<int, HashSet<int>>> dict = new Dictionary<int, Dictionary<int, HashSet<int>>>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!rowSet.ContainsKey(i))
                        {
                            rowSet.Add(i, new HashSet<int>(9));
                        }
                        rowSet[i].Add(Convert.ToInt32(board[i][j].ToString()));

                    }
                    else
                    {
                        listNode.Add(new Node() { X = i, Y = j });
                    }

                    if (board[j][i] != '.')
                    {
                        if (!colSet.ContainsKey(j))
                        {
                            colSet.Add(j, new HashSet<int>(9));
                        }
                        colSet[j].Add(Convert.ToInt32(board[j][i].ToString()));

                    }
                }
            }

            foreach (var node in list)
            {
                for (int i = node.beginX; i < node.endX; i++)
                {
                    for (int j = node.beginY; j < node.endY; j++)
                    {
                        if (board[i][j] == '.')
                        {
                            continue;
                        }
                        node.boxSet.Add(Convert.ToInt32(board[i][j].ToString()));
                    }
                }
            }

            int index = 0;
            bool isOk = true;
            Node nodeData = null;
            NodeModel nodeModel = null;
            while (index < listNode.Count)
            {
                if (isOk)
                {
                    nodeData = listNode[index];
                    nodeModel = GetBox(nodeData.X, nodeData.Y, list);
                }

                if (!dict.ContainsKey(nodeData.X))
                {
                    dict.Add(nodeData.X, new Dictionary<int, HashSet<int>>());
                }
                var dictNode = dict[nodeData.X];
                if (!dictNode.ContainsKey(nodeData.Y))
                {
                    dictNode.Add(nodeData.Y, new HashSet<int>(9));
                }

                int num = GetNum(rowSet[nodeData.X], colSet[nodeData.Y], nodeModel.boxSet, dict[nodeData.X][nodeData.Y]);
                if (num > 0)
                {

                    dict[nodeData.X][nodeData.Y].Add(num);
                    rowSet[nodeData.X].Add(num);
                    colSet[nodeData.Y].Add(num);
                    nodeModel.boxSet.Add(num);
                    nodeData.Value = num;

                    index++;
                    isOk = true;
                    board[nodeData.X][nodeData.Y] = char.Parse(num.ToString());
                }
                else
                {
                   
                    
                    if (index > 0) 
                    {
                        index--;
                        isOk = false;
                        nodeData = listNode[index];
                        nodeModel = GetBox(nodeData.X, nodeData.Y, list);

                        rowSet[nodeData.X].Remove(nodeData.Value);
                        colSet[nodeData.Y].Remove(nodeData.Value);
                        nodeModel.boxSet.Remove(nodeData.Value);
                    }
                   
                }
            }
        }

        private NodeModel GetBox(int i, int j, List<NodeModel> list)
        {
            foreach (var node in list)
            {
                if (i >= node.beginX && i < node.endX && j >= node.beginY && j < node.endY)
                {
                    return node;
                }
            }
            return null;
        }

        private int GetNum(HashSet<int> col, HashSet<int> row, HashSet<int> box, HashSet<int> hisSet)
        {
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
                if (hisSet.Contains(i))
                {
                    continue;
                }
                return i;
            }
            return 0;

        }

        class Node
        {
            public int X;
            public int Y;
            public int Value;
        }

        class NodeModel
        {
            public int beginX;
            public int endX;
            public int beginY;
            public int endY;
            public HashSet<int> boxSet = new HashSet<int>(9);
        }

    }
}
