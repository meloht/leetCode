using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _241_DifferentWaysToAddParenthesesAlg
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            if (expression.Length == 0)
                return new List<int>();
            if (!expression.Contains("+") && !expression.Contains("-") && !expression.Contains("*"))
                return [int.Parse(expression)];

            List<int> nums = new List<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];
                if (ch == '+' || ch == '-' || ch == '*')
                {
                    var left = DiffWaysToCompute(expression.Substring(0, i));
                    var right = DiffWaysToCompute(expression.Substring(i + 1));

                    foreach (var l in left)
                    {
                        foreach (var r in right)
                        {
                            if (ch == '+')
                            {
                                nums.Add(l + r);
                            }
                            else if (ch == '-')
                            {
                                nums.Add(l - r);
                            }
                            else
                            {
                                nums.Add(l * r);
                            }
                        }
                    }
                }
            }

            return nums;
        }



    }
}
