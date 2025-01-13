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

        public int[] AsteroidCollision1(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int aster in asteroids)
            {
                bool alive = true;
                while (alive && aster < 0 && stack.Count > 0 && stack.Peek() > 0)
                {
                    alive = stack.Peek() < -aster; // aster 是否存在
                    if (stack.Peek() <= -aster)
                    {  // 栈顶行星爆炸
                        stack.Pop();
                    }
                }
                if (alive)
                {
                    stack.Push(aster);
                }
            }
            int count = stack.Count;
            int[] ans = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                ans[i] = stack.Pop();
            }
            return ans;
        }

    }
}
