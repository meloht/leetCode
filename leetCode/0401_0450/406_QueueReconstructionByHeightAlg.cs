using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{

    public class _406_QueueReconstructionByHeightAlg
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (x, y) =>
            {
                if (x[0].CompareTo(y[0]) == 0)
                {
                    return x[1].CompareTo(y[1]);
                }
                return y[0].CompareTo(x[0]);
            });

            List<int[]> res = new List<int[]>();

            foreach (var item in people)
            {
                if (res.Count <= item[1])
                {
                    res.Add(item);
                }
                else if (res.Count > item[1])
                {
                    res.Insert(item[1], item);
                }
            }

            return res.ToArray();
        }


    }
}
