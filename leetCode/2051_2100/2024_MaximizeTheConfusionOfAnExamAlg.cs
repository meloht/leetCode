using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2024_MaximizeTheConfusionOfAnExamAlg
    {
        public int MaxConsecutiveAnswers(string answerKey, int k)
        {
            int ans = GetMax(answerKey, k, 'T');
            ans = Math.Max(ans, GetMax(answerKey, k, 'F'));
            return ans;
        }

        private int GetMax(string answerKey, int k, char ch)
        {
            int ans = 0;
            int first = 0;

            int t = 0;
            for (int i = 0; i < answerKey.Length; i++)
            {
                if (answerKey[i] == ch)
                {
                    t++;
                    while (t > k)
                    {
                        if (answerKey[first] == ch)
                        {
                            t--;
                        }
                        first++;
                    }

                }
                ans = Math.Max(ans, i - first + 1);
            }

            return ans;
        }
    }
}
