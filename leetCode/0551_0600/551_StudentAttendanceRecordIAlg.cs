using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _551_StudentAttendanceRecordIAlg
    {
        public bool CheckRecord(string s)
        {
            int a = s.Count(p => p == 'A');
            int l = s[0] == 'L' ? 1 : 0;
            if (a >= 2)
                return false;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == 'L' && s[i] == 'L')
                {
                    l++;
                    if (l >= 3)
                    {
                        return false;
                    }
                }
                else
                {
                    if (l >= 3)
                    {
                        return false;
                    }
                    if (s[i] == 'L')
                    {
                        l = 1;
                    }
                    else
                    {
                        l = 0;
                    }
                }
            }

            return true;
        }

        public bool CheckRecord1(string s)
        {
            int absents = 0, lates = 0;
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                char c = s[i];
                if (c == 'A')
                {
                    absents++;
                    if (absents >= 2)
                    {
                        return false;
                    }
                }
                if (c == 'L')
                {
                    lates++;
                    if (lates >= 3)
                    {
                        return false;
                    }
                }
                else
                {
                    lates = 0;
                }
            }
            return true;
        }


    }
}
