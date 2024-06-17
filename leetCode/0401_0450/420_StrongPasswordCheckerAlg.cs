using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _420_StrongPasswordCheckerAlg
    {
        public int StrongPasswordChecker(string password)
        {
            int upDec = 0;
            int lowDec = 0;
            int numDec = 0;


            for (int i = 0; i < password.Length - 1; i++)
            {
                int cnt = 1;
                int idx = i;
                for (int j = i + 1; j < password.Length; j++)
                {
                    if (password[i] == password[j])
                    {
                        cnt++;
                        i = j;
                    }
                    else
                    {
                        break;
                    }
                }
                if (cnt >= 3)
                {
                    if (char.IsDigit(password[idx]))
                    {
                        numDec += (cnt - 2);
                    }
                    else if (char.IsLetter(password[i]) && char.IsUpper(password[i]))
                    {
                        upDec += (cnt - 2);
                    }
                    else if (char.IsLetter(password[i]) && char.IsLower(password[i]))
                    {
                        lowDec += (cnt - 2);
                    }

                }
            }
            int ans = 0;
            int len = password.Length;
            int lenAdd = 0;
            int lowNum = password.Count(p => char.IsLetter(p) && char.IsLower(p));
            int upNum = password.Count(p => char.IsLetter(p) && char.IsUpper(p));
            int numCnt = password.Count(p => char.IsDigit(p));
            if (len < 6)
            {
                lenAdd = 6 - len;
            }
            if (upNum == 0)
            {
                if (lenAdd > 0)
                {
                    len++;
                    lenAdd--;
                }
                else if (lowNum > 1)
                {
                    if (lowDec > 0)
                    {
                        lowDec--;
                    }
                }
                else if (numCnt > 1)
                {
                    if (numDec > 0)
                    {
                        numDec--;
                    }
                }
                else
                {
                    len++;
                }
                upNum++;
                ans++;
            }
            if (lowNum == 0)
            {
                if (lenAdd > 0)
                {
                    len++;
                    lenAdd--;
                }
                else if (upNum > 1)
                {
                    if (upDec > 0)
                    {
                        upDec--;
                    }
                }
                else if (numCnt > 1)
                {
                    if (numDec > 0)
                    {
                        numDec--;
                    }
                }
                else
                {
                    len++;
                }

                ans++;
                lowNum++;
            }
            if (numCnt == 0)
            {
                if (lenAdd > 0)
                {
                    len++;
                    lenAdd--;
                }
                else if (upNum > 1)
                {
                    if (upDec > 0)
                    {
                        upDec--;
                    }
                }
                else if (lowNum > 1)
                {
                    if (lowDec > 0)
                    {
                        lowDec--;
                    }
                }
                else
                {
                    len++;
                }

                ans++;
                numCnt++;
            }
            if (len < 6)
            {
                ans += 6 - len;
            }
            else if (len > 20)
            {
                ans += len - 20;
            }

            ans += (lowDec + numDec + upDec);


            return ans;
        }
    }
}
