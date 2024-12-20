using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _649_Dota2SenateAlg
    {
        public string PredictPartyVictory(string senate)
        {
            int rr = 0;
            int dd = 0;
            Queue<char> queue = new Queue<char>();
            foreach (var item in senate)
            {
                queue.Enqueue(item);
                if (item == 'R')
                {
                    rr++;
                }
                else
                {
                    dd++;
                }
            }
           
            int r = 0;
            int d = 0;
  
            while (queue.Count > 0)
            {
                int count = queue.Count;
                if (queue.Count == rr)
                {
                    return "Radiant";
                }
                if (queue.Count == dd)
                {
                    return "Dire";
                }
                dd = 0;
                rr = 0;
                for (int i = 0; i < count; i++)
                {
                    var ch = queue.Dequeue();
                    if (ch == 'R')
                    {
                        if (d > 0)
                        {
                            d--;
                        }
                        else
                        {
                            queue.Enqueue(ch);
                            r++;
                            rr++;
                        }
                    }
                    else
                    {

                        if (r > 0)
                        {
                            r--;
                        }
                        else
                        {
                            d++;
                            dd++;
                            queue.Enqueue(ch);
                        }
                    }
                }
            }
            return "";
        }
    }
}
