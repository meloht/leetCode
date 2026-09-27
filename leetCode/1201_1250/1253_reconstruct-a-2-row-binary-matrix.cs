using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1201_1250
{
    public class _1253_reconstruct_a_2_row_binary_matrix
    {
        public IList<IList<int>> ReconstructMatrix(int upper, int lower, int[] colsum)
        {
            int sum = colsum.Sum();
            if (sum != upper + lower)
                return [];
            IList<IList<int>> ans = new List<IList<int>>();
            ans.Add(new int[colsum.Length]);
            ans.Add(new int[colsum.Length]);

            int[] arr=new int[colsum.Length];
            bool bl = upper > lower;
            for (int i = 0; i < colsum.Length; i++)
            {
                arr[i] = i;
            }

            Array.Sort(arr, (x, y) => colsum[y] - colsum[x]);

            for (int i = 0; i < arr.Length; i++)
            {
                int idx = arr[i];
                if (bl)
                {
                    if (upper > 0 && colsum[idx] > 0)
                    {
                        ans[0][idx] = 1;
                        upper--;
                        colsum[idx]--;
                    }
                    if (lower > 0 && colsum[idx] > 0)
                    {

                        ans[1][idx] = 1;
                        lower--;
                        colsum[idx]--;
                    }
                }
                else
                {
                    if (lower > 0 && colsum[idx] > 0)
                    {

                        ans[1][idx] = 1;
                        lower--;
                        colsum[idx]--;
                    }
                    if (upper > 0 && colsum[idx] > 0)
                    {
                        ans[0][idx] = 1;
                        upper--;
                        colsum[idx]--;
                    }
                }

                if (colsum[idx] > 0)
                {
                    return [];
                }

            }

            return ans;
        }
    }
}
