using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _777_SwapAdjacentInLrStringAlg
    {
        public bool CanTransform(string start, string end)
        {
            if (start.Length != end.Length)
            {
                return false;
            }

            int n = start.Length;
            int i = 0, j = 0;

            while (i < n || j < n)
            {
                while (i < n && start[i] == 'X')
                {
                    i++;
                }
                while (j < n && end[j] == 'X')
                {
                    j++;
                }

                if (i < n && j < n)
                {
                    if (start[i] != end[j])
                    {
                        return false;
                    }

                    if (start[i] == 'L' && i < j)
                    {
                        return false;
                    }

                    if (start[i] == 'R' && i > j)
                    {
                        return false;
                    }

                    i++;
                    j++;
                }
                else if (i < n || j < n)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CanTransform1(string start, string end)
        {
            if (start.Replace("X", "") != end.Replace("X", ""))
                return false;


            for (int i = 0, j = 0; i < start.Length; i++)
            {
                if (start[i] == 'X')
                    continue;
                while (end[j] == 'X')
                {
                    j++;
                }
                if (i != j && (start[i] == 'L') != (i > j))
                {
                    return false;
                }
                j++;
            }

            return true;
        }
    }
}
