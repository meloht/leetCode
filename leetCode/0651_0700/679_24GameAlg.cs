using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0651_0700
{
    public class _679_24GameAlg
    {
        int target = 24;
        int ADD = 0, MULTIPLY = 1, SUBTRACT = 2, DIVIDE = 3;
        double EPSILON = 1e-6;
        public bool JudgePoint24(int[] cards)
        {
            List<double> list = new List<double>();
            foreach (int item in cards)
            {
                list.Add((double)item);
            }

            return Solve(list);
        }

        public bool Solve(List<double> list)
        {
            if (list.Count == 0)
                return false;
            if (list.Count == 1)
            {
                return Math.Abs(list[0] - target) < EPSILON;
            }

            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == j)
                        continue;
                    List<double> ls = new List<double>();
                    for (int k = 0; k < count; k++)
                    {
                        if (k != i && k != j)
                        {
                            ls.Add(list[k]);
                        }
                    }

                    for (int k = 0; k < 4; k++)
                    {
                        if (k < 2 && i > j)
                        {
                            continue;
                        }
                        if (k == ADD)
                        {
                            ls.Add(list[i] + list[j]);
                        }
                        else if (k == MULTIPLY)
                        {
                            ls.Add(list[i] * list[j]);
                        }
                        else if (k == SUBTRACT)
                        {
                            ls.Add(list[i] - list[j]);
                        }
                        else if (k == DIVIDE)
                        {
                            if (Math.Abs(list[j]) < EPSILON)
                            {
                                continue;
                            }
                            else
                            {
                                ls.Add(list[i] / list[j]);
                            }
                        }
                        if (Solve(ls))
                        {
                            return true;
                        }
                        ls.RemoveAt(ls.Count - 1);
                    }
                }
            }


            return false;
        }



        private bool Helper(double[] nums)
        {
            if (nums.Length == 1) return Math.Abs(nums[0] - target) < EPSILON;
            // 每次选择两个不同的数进行回溯
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // 将选择出来的两个数的计算结果和原数组剩下的数加入 next 数组
                    double[] next = new double[nums.Length - 1];
                    for (int k = 0, pos = 0; k < nums.Length; k++) 
                    {
                        if (k != i && k != j)
                            next[pos++] = nums[k];
                    }
                      
                    var ls = Calculate(nums[i], nums[j]);
                    foreach (double num in ls)
                    {
                        next[next.Length - 1] = num;
                        if (Helper(next)) return true;
                    }
                }
            }
            return false;
        }

        private List<double> Calculate(double a, double b)
        {
            List<Double> list = new List<double>();
            list.Add(a + b);
            list.Add(a - b);
            list.Add(b - a);
            list.Add(a * b);
            if (!(Math.Abs(b) < EPSILON)) list.Add(a / b);
            if (!(Math.Abs(a) < EPSILON)) list.Add(b / a);
            return list;
        }


    }
}
