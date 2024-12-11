using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _640_SolveTheEquationAlg
    {
        public string SolveEquation(string equation)
        {
            string[] arr = equation.Split('=', StringSplitOptions.RemoveEmptyEntries);

            int[] left = getXVal(arr[0]);
            int x = left[0];
            int val = -left[1];
            int[] right = getXVal(arr[1]);
            x -= right[0];
            val += right[1];

            if (x == 0 && val == 0)
            {
                return "Infinite solutions";
            }
            if (x == 0 && val != 0)
            {
                return "No solution";
            }
            if (Math.Abs(val) % Math.Abs(x) != 0)
            {
                return "No solution";
            }

            return $"x={val / x}";
        }
        private int[] getXVal(string s)
        {
            int x = 0;
            int val = 0;
            int i = 0;

            while (i < s.Length)
            {
                if (s[i] == '+' || s[i] == '-')
                {

                    int ch = s[i] == '-' ? -1 : 1;
                    i++;
                    if (char.IsDigit(s[i]))
                    {
                       
                        StringBuilder sb = new StringBuilder();
                        while (i < s.Length && char.IsDigit(s[i]))
                        {
                            sb.Append(s[i]);
                            i++;
                        }
                        if (i < s.Length && s[i] == 'x')
                        {
                            x += ch * int.Parse(sb.ToString());
                        }
                        else
                        {
                            val += ch * int.Parse(sb.ToString());
                            continue;
                        }
                    }
                    else
                    {
                        x += ch;
                    }
                }
                else if (char.IsDigit(s[i]))
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        sb.Append(s[i]);
                        i++;
                    }
                    if (i < s.Length && s[i] == 'x')
                    {
                        x += int.Parse(sb.ToString());
                    }
                    else
                    {
                        val += int.Parse(sb.ToString());
                        continue;
                    }

                }
                else if (s[i] == 'x')
                {
                    x++;
                }
                i++;
            }

            return [x, val];
        }
    }
}
