﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _817_LinkedListComponentsAlg
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            int ans = 0;
            HashSet<int> set = new HashSet<int>(nums);
            ListNode node = head;
            bool bl = false;
            while (node != null)
            {
                if (set.Contains(node.val))
                {
                    if (!bl)
                    {
                        bl = true;
                        ans++;
                    }
                 
                }
                else
                {

                    bl = false;
                }
                node = node.next;
            }
           

            return ans;
        }
    }
}
