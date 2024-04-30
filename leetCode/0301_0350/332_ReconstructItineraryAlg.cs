using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _332_ReconstructItineraryAlg
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, PriorityQueue<string, string>> dict = new Dictionary<string, PriorityQueue<string, string>>();
            foreach (var item in tickets)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]].Enqueue(item[1], item[1]);
                }
                else
                {
                    PriorityQueue<string, string> queue = new PriorityQueue<string, string>();
                    queue.Enqueue(item[1], item[1]);
                    dict.Add(item[0], queue);
                }
            }

           
            List<string> ls = new List<string>();
            Dfs(dict, "JFK", ls);
            ls.Reverse();
            return ls;
        }

        private void Dfs(Dictionary<string, PriorityQueue<string, string>> dict, string item,  List<string> ls)
        {
            while (dict.ContainsKey(item) && dict[item].Count > 0)
            {
                string curr = dict[item].Dequeue();
                Dfs(dict, curr, ls);
            }
            ls.Add(item);
        }
    }
}
