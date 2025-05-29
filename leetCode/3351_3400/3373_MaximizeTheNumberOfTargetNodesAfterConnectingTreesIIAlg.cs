using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3351_3400
{
    public class _3373_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIIAlg
    {
        public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
        {
            int n = edges1.Length + 1;
           
            List<int>[] arr1 = GetAdjArr(edges1);
            List<int>[] arr2 = GetAdjArr(edges2);


            int[] cnt2 = new int[2];
            Dfs(0, -1, 0, arr2, cnt2);
            int max2 = Math.Max(cnt2[0], cnt2[1]);


            int[] cnt1 = new int[2];
            Dfs(0, -1, 0, arr1, cnt1);
            int[] ans = new int[n];
            Array.Fill(ans, max2);
            Dfs1(0, -1, 0, arr1, cnt1, ans);

            return ans;
        }



        private List<int>[] GetAdjArr(int[][] edges)
        {
            List<int>[] arr = new List<int>[edges.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new List<int>();
            }

            foreach (var item in edges)
            {
                arr[item[0]].Add(item[1]);
                arr[item[1]].Add(item[0]);
            }
            return arr;
        }

        private void Dfs(int x, int fa, int d, List<int>[] arr, int[] cnt)
        {
            cnt[d]++;
            foreach (var item in arr[x])
            {
                if (item != fa)
                {
                    Dfs(item, x, d ^ 1, arr, cnt);
                }
            }
        }

        private void Dfs1(int x, int fa, int d, List<int>[] arr, int[] cnt, int[] ans)
        {
            ans[x] += cnt[d];
            foreach (var item in arr[x])
            {
                if (item != fa)
                {
                    Dfs1(item, x, d ^ 1, arr, cnt, ans);
                }
            }
        }
    }
}
