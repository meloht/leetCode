using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2225_FindPlayersWithZeroOrOneLossesAlg
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            Dictionary<int, int> dictWinner = new Dictionary<int, int>();
            Dictionary<int, int> dictLoser = new Dictionary<int, int>();
            List<int> listWinner = new List<int>();
            List<int> listLoser = new List<int>();
            foreach (var item in matches)
            {
                if (dictWinner.ContainsKey(item[0]))
                {
                    dictWinner[item[0]]++;
                }
                else
                {
                    dictWinner.Add(item[0], 1);
                }

                if (dictLoser.ContainsKey(item[1]))
                {
                    dictLoser[item[1]]++;
                }
                else
                {
                    dictLoser.Add(item[1], 1);
                }
            }
            foreach (var item in dictWinner.Keys)
            {
                if (!dictLoser.ContainsKey(item))
                {
                    listWinner.Add(item);
                }
            }

            foreach (var item in dictLoser)
            {
                if (item.Value==1)
                {
                    listLoser.Add(item.Key);
                }
            }

            listWinner.Sort();
            listLoser.Sort();

            return [listWinner,listLoser];
        }
    }
}
