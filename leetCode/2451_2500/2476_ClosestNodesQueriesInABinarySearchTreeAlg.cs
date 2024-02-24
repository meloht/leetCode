using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._2451_2500
{
    public class _2476_ClosestNodesQueriesInABinarySearchTreeAlg
    {
        public IList<IList<int>> ClosestNodes(TreeNode root, IList<int> queries)
        {
            List<int> numList = new List<int>();
            MidOrder(root, numList);
            List<IList<int>> res = new List<IList<int>>();
            foreach (var item in queries)
            {
                int[] ans = GetNum(numList, item);
                res.Add(ans);
            }
            return res;
        }

        private void MidOrder(TreeNode root, List<int> numList)
        {
            if (root == null)
                return;
            MidOrder(root.left, numList);
            numList.Add(root.val);
            MidOrder(root.right, numList);
        }

        private int[] GetNum(List<int> numList, int target)
        {
            int[] ans = new int[2];
            Array.Fill(ans, -1);

            int left = 0;
            int right = numList.Count - 1;
            if (target > numList[right])
            {
                ans[0] = numList[right];
                return ans;
            }
            if (target < numList[left])
            {
                ans[1] = numList[left];
                return ans;
            }
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midVal = numList[mid];
                if (midVal == target)
                {
                    ans[0] = midVal;
                    ans[1] = midVal;
                    return ans;
                }
                else if (midVal < target)
                {
                    int next = mid + 1;
                    if (next < numList.Count && numList[next] > target)
                    {
                        ans[0] = midVal;
                        ans[1] = numList[next];
                        return ans;
                    }
                    left = next;
                }
                else //numList[mid] > target
                {
                    int next = mid - 1;
                    if (next >= 0 && numList[next] < target)
                    {
                        ans[0] = numList[next];
                        ans[1] = midVal;
                        return ans;
                    }
                    right = next;
                }
            }

            return ans;
        }
    }
}
