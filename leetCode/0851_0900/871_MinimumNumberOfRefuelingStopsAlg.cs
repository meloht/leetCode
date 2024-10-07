using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _871_MinimumNumberOfRefuelingStopsAlg
    {
        public int MinRefuelStops(int target, int startFuel, int[][] stations)
        {
            int n = stations.Length;
            int ans = 0;
            int prePosition = 0;
            int curFuel = startFuel;
            PriorityQueue<int,int> fuelHeap = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a))); // 最大堆
            for (int i = 0; i <= n; i++)
            {
                int position = i < n ? stations[i][0] : target;
                curFuel -= position - prePosition; // 每行驶 1 英里用掉 1 升汽油
                while (fuelHeap.Count>0 && curFuel < 0)
                { // 没油了
                    curFuel += fuelHeap.Dequeue(); // 选油量最多的油桶
                    ans++;
                }
                if (curFuel < 0)
                { // 无法到达
                    return -1;
                }
                int num = i < n ? stations[i][1] : 0;
                fuelHeap.Enqueue(num, num); // 留着后面加油
                prePosition = position;
            }
            return ans;


        }
    }
}
