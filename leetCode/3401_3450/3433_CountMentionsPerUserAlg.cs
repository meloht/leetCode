using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3433_CountMentionsPerUserAlg
    {
        public int[] CountMentions(int numberOfUsers, IList<IList<string>> events)
        {
            var list = events.ToList();
            list.Sort((a, b) =>
            {
                int ta = int.Parse(a[1]);
                int tb = int.Parse(b[1]);
                return ta != tb ? ta - tb : b[0][0] - a[0][0];
            });

            int[] ans = new int[numberOfUsers];
            int[] onlineT = new int[numberOfUsers];

            foreach (var item in list)
            {
                int curT = int.Parse(item[1]);
                string mention = item[2];
                if (item[0][0] == 'O')
                {
                    onlineT[int.Parse(mention)] = curT + 60;
                }
                else if (mention[0] == 'A')
                {
                    for (int i = 0; i < numberOfUsers; i++)
                    {
                        ans[i]++;
                    }
                }
                else if (mention[0] == 'H')
                { // @所有在线用户
                    for (int i = 0; i < numberOfUsers; i++)
                    {
                        if (onlineT[i] <= curT)
                        { // 在线
                            ans[i]++;
                        }
                    }
                }
                else
                {
                    string[] arr = mention.Split(' ');
                    foreach (var item1 in arr)
                    {
                        int i = int.Parse(item1.Substring(2));
                        ans[i]++;
                    }
                }
            }

            return ans;
        }
    }
}
