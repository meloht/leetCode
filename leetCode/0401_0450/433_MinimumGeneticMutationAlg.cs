using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _433_MinimumGeneticMutationAlg
    {
        public int MinMutation(string startGene, string endGene, string[] bank)
        {
            if (bank.Length == 0 && startGene != endGene)
                return -1;

            if (startGene == endGene)
                return 0;
         
            int ans = 0;
            HashSet<string> used=new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            bool blExist = false;
            foreach (var item in bank)
            {
                if (item == endGene)
                {
                    blExist = true;
                }
                int n = GetDiff(item, startGene);
                if (n == 1)
                {
                    queue.Enqueue(item);
                    used.Add(item);
                }
            }
            if (blExist == false)
                return -1;
            ans++;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var item = queue.Dequeue();
                    if (item == endGene)
                        return ans;

                    foreach (var item2 in bank)
                    {
                        if (used.Contains(item2))
                            continue;

                        int n = GetDiff(item, item2);
                        if (n == 1)
                        {
                            queue.Enqueue(item2);
                            used.Add(item2);
                        }
                    }
                }

                ans++;

            }
            return -1;
        }
        private int GetDiff(string a, string b)
        {
            int n = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    n++;
                }
            }
            return n;
        }

    }
}
