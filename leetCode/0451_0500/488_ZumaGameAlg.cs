﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _488_ZumaGameAlg
    {
        public int FindMinStep(string board, string hand)
        {
            char[] arr = hand.ToCharArray();
            Array.Sort(arr);
            hand = new string(arr);

            // 初始化用队列维护的状态队列：其中的三个元素分别为桌面球状态、手中球状态和回合数
            Queue<State> queue = new Queue<State>();
            queue.Enqueue(new State(board, hand, 0));

            // 初始化用哈希集合维护的已访问过的状态
            ISet<string> visited = new HashSet<string>();
            visited.Add(board + "#" + hand);

            while (queue.Count > 0)
            {
                State state = queue.Dequeue();
                string curBoard = state.board;
                string curHand = state.hand;
                int step = state.step;
                for (int i = 0; i <= curBoard.Length; ++i)
                {
                    for (int j = 0; j < curHand.Length; ++j)
                    {
                        // 第 1 个剪枝条件: 当前球的颜色和上一个球的颜色相同
                        if (j > 0 && curHand[j] == curHand[j - 1])
                        {
                            continue;
                        }

                        // 第 2 个剪枝条件: 只在连续相同颜色的球的开头位置插入新球
                        if (i > 0 && curBoard[i - 1] == curHand[j])
                        {
                            continue;
                        }

                        // 第 3 个剪枝条件: 只在以下两种情况放置新球
                        //  - 第 1 种情况 : 当前球颜色与后面的球的颜色相同
                        //  - 第 2 种情况 : 当前后颜色相同且与当前颜色不同时候放置球
                        bool choose = false;
                        if (i > 0 && i < curBoard.Length && curBoard[i - 1] == curBoard[i] && curBoard[i - 1] != curHand[j])
                        {
                            choose = true;
                        }
                        if (i < curBoard.Length && curBoard[i] == curHand[j])
                        {
                            choose = true;
                        }

                        if (choose)
                        {
                            string newBoard = Clean(curBoard.Substring(0, i) + curHand[j] + curBoard.Substring(i));
                            string newHand = curHand.Substring(0, j) + curHand.Substring(j + 1);
                            if (newBoard.Length == 0)
                            {
                                return step + 1;
                            }
                            string str = newBoard + "#" + newHand;
                            if (visited.Add(str))
                            {
                                queue.Enqueue(new State(newBoard, newHand, step + 1));
                            }
                        }
                    }
                }
            }
            return -1;

        }

        public string Clean(string s)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> letterStack = new Stack<char>();
            Stack<int> countStack = new Stack<int>();

            foreach (char c in s)
            {
                while (letterStack.Count > 0 && c != letterStack.Peek() && countStack.Peek() >= 3)
                {
                    letterStack.Pop();
                    countStack.Pop();
                }
                if (letterStack.Count == 0 || c != letterStack.Peek())
                {
                    letterStack.Push(c);
                    countStack.Push(1);
                }
                else
                {
                    countStack.Push(countStack.Pop() + 1);
                }
            }
            if (countStack.Count > 0 && countStack.Peek() >= 3)
            {
                letterStack.Pop();
                countStack.Pop();
            }
            while (letterStack.Count > 0)
            {
                char letter = letterStack.Pop();
                int count = countStack.Pop();
                for (int i = 0; i < count; ++i)
                {
                    sb.Append(letter);
                }
            }
            StringBuilder res = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; --i)
            {
                res.Append(sb[i]);
            }
            return res.ToString();
        }


        class State
        {
            public string board;
            public string hand;
            public int step;

            public State(string board, string hand, int step)
            {
                this.board = board;
                this.hand = hand;
                this.step = step;
            }
        }

    }
}
