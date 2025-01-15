using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _764_LargestPlusSignAlg
    {
        public int OrderOfLargestPlusSign(int n, int[][] mines)
        {
            Node[,] arr = new Node[n, n];
            int[][] mat = new int[n][];
            for (int i = 0; i < n; i++)
            {
                mat[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mat[i][j] = 1;
                    arr[i, j] = new Node();
                }
            }

            foreach (var item in mines)
            {
                mat[item[0]][item[1]] = 0;
            }


            for (int i = 0; i < n; i++)
            {
                int left = 0;
                int right = 0;
                int top = 0;
                int bottom = 0;
                for (int j = 0, k = n - 1; j < n; j++, k--)
                {
                    if (mat[i][j] == 0)
                    {
                        left = 0;
                    }
                    else
                    {
                        left++;
                    }
                    arr[i, j].Left = left;

                    if (mat[i][k] == 0)
                    {
                        right = 0;
                    }
                    else
                    {
                        right++;
                    }
                    arr[i, k].Right = right;


                    if (mat[j][i] == 0)
                    {
                        top = 0;
                    }
                    else
                    {
                        top++;
                    }
                    arr[j, i].Top = top;

                    if (mat[k][i] == 0)
                    {
                        bottom = 0;
                    }
                    else
                    {
                        bottom++;
                    }
                    arr[k, i].Bottom = bottom;
                }
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var node = arr[i, j];
                    int k = Math.Min(node.Left, node.Right);
                    k = Math.Min(k, Math.Min(node.Top, node.Bottom));
                    ans = Math.Max(ans, k);
                }
            }

            return ans;
        }

        public struct Node
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }
    }
}
