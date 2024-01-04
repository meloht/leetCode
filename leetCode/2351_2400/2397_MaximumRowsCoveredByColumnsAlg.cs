using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2351_2400
{
    public class _2397_MaximumRowsCoveredByColumnsAlg
    {
        public int MaximumRows(int[][] matrix, int numSelect)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int[] zero = new int[n];
            List<int> list = new List<int>();
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                if (matrix[i].SequenceEqual(zero))
                {
                    max++;
                }
                else
                {
                    list.Add(i);
                }
            }

            List<int> selectNum = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[j][i] == 1)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    selectNum.Add(i);
                }
            }
            List<int[]> listRes = new List<int[]>();
            if (numSelect >= selectNum.Count)
            {
                listRes.Add(selectNum.ToArray());
            }
            else
            {
                listRes = GenerateCombinations(selectNum.ToArray(), numSelect);
            }
            int maxCount = 0;
            int maxNum = 0;
            foreach (int[] select in listRes)
            {
                maxCount = 0;
                List<int> noselect = new List<int>();
                HashSet<int> set = new HashSet<int>(select);
                for (int i = 0; i < n; i++)
                {
                    if (!set.Contains(i))
                    {
                        noselect.Add(i);
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    int index = list[i];
                    bool num1 = false;
                    bool num2 = true;
                    foreach (var item in select)
                    {
                        if (matrix[index][item] == 1)
                        {
                            num1 = true;
                            break;
                        }
                    }
                    foreach (var item in noselect)
                    {
                        if (matrix[index][item] == 1)
                        {
                            num1 = false;
                            break;
                        }
                    }
                    if (num1 && num2)
                    {
                        maxCount++;
                    }
                }
                maxNum = Math.Max(maxCount, maxNum);
            }

            return max + maxNum;
        }

        private List<int[]> GenerateCombinations(int[] arr, int r)
        {
            List<int[]> res = new List<int[]>();
            int[] data = new int[r];
            GenerateCombinationsUtil(arr, data, 0, arr.Length - 1, 0, r, res);
            return res;
        }

        private void GenerateCombinationsUtil(int[] arr, int[] data, int start, int end, int index, int r, List<int[]> res)
        {
            if (index == r)
            {
                int[] nums = new int[r];
                Array.Copy(data, nums, r);
                res.Add(nums);
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                GenerateCombinationsUtil(arr, data, i + 1, end, index + 1, r, res);
            }
        }

    }
}
