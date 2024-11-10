﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _591_TagValidatorAlg
    {
        public bool IsValid(string code)
        {
            int n = code.Length;
            Stack<string> tags = new Stack<string>();

            int i = 0;
            while (i < n)
            {
                if (code[i] == '<')
                {
                    if (i == n - 1)
                    {
                        return false;
                    }
                    if (code[i + 1] == '/')
                    {
                        int j = code.IndexOf('>', i);
                        if (j < 0)
                        {
                            return false;
                        }
                        string tagname = code.Substring(i + 2, j - (i + 2));
                        if (tags.Count == 0 || !tags.Peek().Equals(tagname))
                        {
                            return false;
                        }
                        tags.Pop();
                        i = j + 1;
                        if (tags.Count == 0 && i != n)
                        {
                            return false;
                        }
                    }
                    else if (code[i + 1] == '!')
                    {
                        if (tags.Count == 0)
                        {
                            return false;
                        }
                        if (i + 9 > n)
                        {
                            return false;
                        }
                        string cdata = code.Substring(i + 2, 7);
                        if (!"[CDATA[".Equals(cdata))
                        {
                            return false;
                        }
                        int j = code.IndexOf("]]>", i);
                        if (j < 0)
                        {
                            return false;
                        }
                        i = j + 3;
                    }
                    else
                    {
                        int j = code.IndexOf('>', i);
                        if (j < 0)
                        {
                            return false;
                        }
                        string tagname = code.Substring(i + 1, j - (i + 1));
                        if (tagname.Length < 1 || tagname.Length > 9)
                        {
                            return false;
                        }
                        foreach (char c in tagname)
                        {
                            if (!char.IsUpper(c))
                            {
                                return false;
                            }
                        }
                        tags.Push(tagname);
                        i = j + 1;
                    }
                }
                else
                {
                    if (tags.Count == 0)
                    {
                        return false;
                    }
                    ++i;
                }
            }

            return tags.Count == 0;
        }

    }
}
