using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{

    public class LongestValidParenthesesAlg
    {

        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            string sub = s;
            int max = 0;
            int numMax = 0;
            int tempLen = 0;
            int tempLen2 = 0;
            int level = 0;

            while (sub.Length > max)
            {
                numMax = 0;
                tempLen = 0;
                tempLen2 = 0;
                level = 0;

                for (int i = 0; i < sub.Length; i++)
                {
                    if (sub[i] == '(')
                    {
                        level++;
                        tempLen2++;

                    }
                    else
                    {
                        if (level == 0)
                        {
                            tempLen += tempLen2;
                            if (tempLen > numMax)
                            {
                                numMax = tempLen;
                            }
                            break;
                        }
                        else if (level > 0)
                        {
                            level--;
                            tempLen2++;

                            if (level == 0)
                            {
                                tempLen += tempLen2;
                                tempLen2 = 0;
                                if (tempLen > numMax)
                                {
                                    numMax = tempLen;

                                }

                            }

                        }
                    }
                }
                if (level == 0)
                {
                    tempLen += tempLen2;
                    if (tempLen > numMax)
                    {
                        numMax = tempLen;

                    }

                }

                if (numMax > 0)
                {
                    if (numMax > max)
                    {
                        max = numMax;
                    }

                    sub = sub.Substring(numMax);
                }
                else
                {
                    sub = sub.Substring(1);
                }

            }

            return max;
        }


        public int LongestValidParentheses3(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            string sub = s;
            int max = 0;

            while (sub.Length > max)
            {
                int num = GetSubMax(sub);
                if (num > 0)
                {
                    if (num > max)
                    {
                        max = num;
                    }

                    sub = sub.Substring(num);
                }
                else
                {
                    sub = sub.Substring(1);
                }

            }

            return max;
        }



        private int GetSubMax(string s)
        {
            int numMax = 0;
            int tempLen = 0;
            int tempLen2 = 0;
            int level = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    level++;
                    tempLen2++;

                }
                else
                {
                    if (level == 0)
                    {
                        tempLen += tempLen2;
                        if (tempLen > numMax)
                        {
                            numMax = tempLen;
                        }
                        break;
                    }
                    else if (level > 0)
                    {
                        level--;
                        tempLen2++;

                        if (level == 0)
                        {
                            tempLen += tempLen2;
                            tempLen2 = 0;
                            if (tempLen > numMax)
                            {
                                numMax = tempLen;

                            }

                        }

                    }
                }
            }
            if (level == 0)
            {
                tempLen += tempLen2;
                if (tempLen > numMax)
                {
                    numMax = tempLen;

                }

            }

            return numMax;
        }

        private int LongestValidParentheses2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int max = 0;
            int tempLen = 0;
            int tempLen2 = 0;
            int level = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    level++;
                    tempLen2++;

                }
                else
                {
                    if (level == 0)
                    {
                        tempLen += tempLen2;
                        if (tempLen > max)
                        {
                            max = tempLen;

                        }
                        tempLen = 0;
                        tempLen2 = 0;
                    }
                    else if (level > 0)
                    {
                        level--;
                        tempLen2++;

                        if (level == 0)
                        {
                            tempLen += tempLen2;
                            tempLen2 = 0;

                        }

                    }
                }

            }


            if (level == 0)
            {
                tempLen += tempLen2;
                if (tempLen > max)
                {
                    max = tempLen;

                }
            }
            else
            {
                tempLen2 = tempLen2 - level;

                List<int> temp = new List<int>() { tempLen, tempLen2, max };
                max = temp.Max();

            }
            return max;
        }
        public int LongestValidParentheses1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int max = 0;
            int tempLen = 0;
            string prefix = "()";
            string sub = s;
            while (true)
            {
                if (sub.StartsWith(prefix))
                {
                    tempLen += prefix.Length;
                    if (tempLen > max)
                    {
                        max = tempLen;
                    }
                    sub = sub.Substring(prefix.Length);
                    if (sub.Length == 0 || sub.Length == 1)
                    {
                        break;
                    }

                }
                else
                {
                    tempLen = 0;
                    sub = sub.Substring(1);
                    if (sub.Length == 0 || sub.Length == 1)
                    {
                        break;
                    }
                }
            }
            return max;
        }
    }
}
