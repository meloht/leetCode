﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode
{
    public class Utils
    {
        public static bool IsSame(IList<IList<int>> list, IList<IList<int>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();
                b.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {
                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();
                    a.Sort();

                    if (a.SequenceEqual(b))
                    {
                        count++;

                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
            return false;
        }
    }
}
