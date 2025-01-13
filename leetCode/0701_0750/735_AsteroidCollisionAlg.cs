using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _735_AsteroidCollisionAlg
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(asteroids[i]);
                }
                else
                {
                    int num = Math.Abs(asteroids[i]);
                    bool flag = false;
                    while (stack.Count > 0)
                    {
                        int prev = stack.Peek();
                        if (asteroids[i] < 0 && prev > 0)
                        {
                            if (num == prev)
                            {
                                flag = false;
                                stack.Pop();
                                break;
                            }
                            else if (num < prev)
                            {
                                flag = false;
                                break;
                            }
                            else if (num > prev)
                            {
                                stack.Pop();
                                flag = true;
                            }
                        }
                        else
                        {
                            flag = false;
                            stack.Push(asteroids[i]);
                            break;
                        }
                    }
                    if (flag)
                    {
                        stack.Push(asteroids[i]);
                    }
                }
            }

            int[] ans = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                ans[i] = stack.Pop();
            }

            return ans;
        }
    }
}
