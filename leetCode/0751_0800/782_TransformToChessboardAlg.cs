using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0751_0800
{
    public class _782_TransformToChessboardAlg
    {
        public int MovesToChessboard(int[][] board)
        {
            int n = board.Length;
            int[] firstRow = board[0];
            int[] firstCol = new int[n];
            int[] rowCnt = new int[2];
            int[] colCnt = new int[2];
            for (int i = 0; i < n; i++)
            {
                rowCnt[firstRow[i]]++; // 统计 0 和 1 的个数
                firstCol[i] = board[i][0];
                colCnt[firstCol[i]]++;
            }

            // 第一行，0 和 1 的个数之差不能超过 1
            // 第一列，0 和 1 的个数之差不能超过 1
            if (Math.Abs(rowCnt[0] - rowCnt[1]) > 1 || Math.Abs(colCnt[0] - colCnt[1]) > 1)
            {
                return -1;
            }

            // 每一行和第一行比较，要么完全相同，要么完全不同
            foreach (int[] row in board)
            {
                bool same = row[0] == firstRow[0];
                for (int i = 0; i < n; i++)
                {
                    if ((row[i] == firstRow[i]) != same)
                    {
                        return -1;
                    }
                }
            }

            return minSwap(firstRow, rowCnt) + minSwap(firstCol, colCnt);


        }

        // 计算最小交换次数
        private int minSwap(int[] arr, int[] cnt)
        {
            int n = arr.Length;
            int x0 = cnt[1] > cnt[0] ? 1 : 0; // 如果 n 是偶数，x0 是 0
            int diff = 0;
            for (int i = 0; i < n; i++)
            {
                diff += i % 2 ^ arr[i] ^ x0;
            }
            return n % 2 > 0 ? diff / 2 : Math.Min(diff, n - diff) / 2;
        }


    }
}
