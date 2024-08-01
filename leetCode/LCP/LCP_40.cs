using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.LCP
{
    public class LCP_40
    {
        public int MaxmiumScore(int[] cards, int cnt)
        {
            int evenCount = cards.Count(p => p % 2 == 0);
            int oddCount = cards.Length - evenCount;
            if (cards.Length == cnt && oddCount % 2 == 1)
                return 0;
            Array.Sort(cards, (x, y) => y.CompareTo(x));

            int ansEven = 0;
            int evenCnt = 0;
            int ansOdd = 0;
            int oddCnt = 0;
            int lastEvenIdx = -1;
            int lastOddIdx = -1;
            for (int i = 0; i < cnt; i++)
            {
                if (cards[i] % 2 == 0)
                {
                    ansEven += cards[i];
                    evenCnt++;
                    lastEvenIdx = i;
                }
                else
                {
                    ansOdd += cards[i];
                    lastOddIdx = i;
                    oddCnt++;
                }
            }

            if (oddCnt % 2 == 0)
            {
                return ansEven + ansOdd;
            }
            List<int> res = new List<int>();
            if (evenCount - evenCnt > 0 && lastOddIdx > -1)
            {
                int ans = ansOdd + ansEven - cards[lastOddIdx];

                for (int i = cnt; i < cards.Length; i++)
                {
                    if (cards[i] % 2 == 0)
                    {
                        ans += cards[i];
                        res.Add(ans);
                        break;
                    }
                }

            }
            if (oddCount - oddCnt > 0 && lastEvenIdx > -1)
            {
                int ans = ansOdd + ansEven - cards[lastEvenIdx];
                for (int i = cnt; i < cards.Length; i++)
                {
                    if (cards[i] % 2 == 1)
                    {
                        ans += cards[i];
                        res.Add(ans);
                        break;
                    }
                }
            }

            if (res.Count > 0)
            {
                return res.Max();
            }

            return 0;
        }
    }
}
