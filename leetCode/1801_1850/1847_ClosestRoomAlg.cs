using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1801_1850
{
    public class _1847_ClosestRoomAlg
    {
        public int[] ClosestRoom(int[][] rooms, int[][] queries)
        {
            int k = queries.Length;
            int[] ans = new int[k];
            Array.Fill(ans, -1);
            Array.Sort(rooms, (x, y) => y[1].CompareTo(x[1]));


            int[] queryIds = new int[k];
            for (int i = 0; i < k; i++)
            {
                queryIds[i] = i;
            }

            Array.Sort(queryIds, (x, y) => queries[y][1].CompareTo(queries[x][1]));

            SortedSet<int> roomIds = new SortedSet<int>();

            int j = 0;
            foreach (int i in queryIds)
            {
                int preferId = queries[i][0];
                int minSize = queries[i][1];

                while (j < rooms.Length && rooms[j][1] >= minSize)
                {
                    roomIds.Add(rooms[j][0]);
                    j++;
                }

                if (roomIds.Count > 0)
                {
                    int diff = int.MaxValue;
                    var floor = roomIds.GetViewBetween(0, preferId).Max;
                    if (floor > 0)
                    {
                        diff = preferId - floor; // 左边的差
                        ans[i] = floor;
                    }

                    var ceiling = roomIds.GetViewBetween(preferId, int.MaxValue).Min;
                    if (ceiling > 0 && ceiling - preferId < diff)
                    {
                        ans[i] = ceiling;
                    }

                }
            }
            return ans;
        }




    }
}
