using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _475_HeatersAlg
    {
        public int FindRadius1(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            List<Node> list = new List<Node>();
            foreach (var item in houses)
            {
                list.Add(new Node() { Val = item, IsHouse = true });
            }
            foreach (var item in heaters)
            {
                list.Add(new Node() { Val = item, IsHouse = false });
            }

            list.Sort((x, y) => x.Val.CompareTo(y.Val));
            int[] arr = new int[heaters.Length];

            for (int j = 0, i = 0; j < list.Count; j++)
            {
                if (list[j].IsHouse == false)
                {
                    arr[i++] = j;
                }
            }
            int ans = int.MinValue;

            if (arr.Length == 1)
            {
                if (arr[0] == list.Count - 1)
                {
                    ans = list[arr[0]].Val - list[0].Val;
                }
                else if (arr[0] == 0)
                {
                    ans = list[list.Count - 1].Val - list[arr[0]].Val;
                }
                else
                {
                    ans = Math.Max(list[arr[0]].Val - list[0].Val, list[list.Count - 1].Val - list[arr[0]].Val);
                }
                return ans;
            }
            if (arr[0] > 0)
            {
                ans = list[arr[0]].Val - list[0].Val;
            }
            if (arr[arr.Length - 1] < list.Count - 1)
            {
                ans = Math.Max(ans, list[list.Count - 1].Val - list[arr[arr.Length - 1]].Val);
            }


            int idx = 1;

            while (idx < arr.Length)
            {
                if (arr[idx] - arr[idx - 1] == 1)
                {
                    idx++;
                    continue;
                }
                int begin = arr[idx - 1] + 1;
                int end = arr[idx] - 1;
                int d = 0;
                for (int i = begin, j = end; i <= j;)
                {
                    int d1 = list[i].Val - list[arr[idx - 1]].Val;
                    int d2 = list[arr[idx]].Val - list[j].Val;
                    if (d1 < d2)
                    {
                        i++;
                        d= d1;
                    }
                    else
                    {
                        d = d2;
                        j--;
                    }
                }
                ans = Math.Max(ans, d);
               
                idx++;
            }


            return ans;
        }
        class Node
        {
            public int Val { get; set; }
            public bool IsHouse { get; set; }
            public override string ToString()
            {
                return $"{Val} {IsHouse}";
            }
        }

        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);
            int ans = 0;
            for (int i = 0, j = 0; i < houses.Length; i++)
            {
                int curDistance = Math.Abs(houses[i] - heaters[j]);
                while (j < heaters.Length - 1 && Math.Abs(houses[i] - heaters[j]) >= Math.Abs(houses[i] - heaters[j + 1]))
                {
                    j++;
                    curDistance = Math.Min(curDistance, Math.Abs(houses[i] - heaters[j]));
                }
                ans = Math.Max(ans, curDistance);
            }
            return ans;
        }


    }
}
