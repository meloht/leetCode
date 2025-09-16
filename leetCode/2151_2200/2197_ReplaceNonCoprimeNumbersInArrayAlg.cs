using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2151_2200
{
    public class _2197_ReplaceNonCoprimeNumbersInArrayAlg
    {
        public IList<int> ReplaceNonCoprimes(int[] nums)
        {

            List<int> st = new List<int>();
            foreach (int x in nums)
            {
                int a = x;

                while (st.Count > 0)
                {
                    int last = st[st.Count - 1];
                    int g = GCD(a, last);
                    if (g > 1)
                    {
                        a = a / g * last;
                        st.RemoveAt(st.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                   
                }
                st.Add(a);
            }
            return st;

        }



        private int Gcd(int a, int b)
        {
            while (a != 0)
            {
                int tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }


        private int Lcm(int a, int b)
        {
            return a / Gcd(a, b)*b;
        }

        public IList<int> ReplaceNonCoprimes2(int[] nums)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                while (ans.Count > 0)
                {
                    int last = ans[ans.Count - 1];
                    int g = GCD(last, num);
                    if (g > 1)
                    {
                        num = last / g * num;
                        ans.RemoveAt(ans.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                ans.Add(num);
            }
            return ans;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
