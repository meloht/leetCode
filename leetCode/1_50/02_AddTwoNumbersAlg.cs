using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class AddTwoNumbersAlg
    {

       

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> list1 = GetArr(l1);
            List<int> list2 = GetArr(l2);

            List<int> list = new List<int>();

            int tem = 0;
            for (int i = 0; i < list1.Count && i < list2.Count; i++)
            {
                int num = list1[i] + list2[i] + tem;
                tem = 0;
                if (num >= 10)
                {
                    int mm = num % 10;
                    list.Add(mm);
                    tem = 1;
                }
                else
                {
                    list.Add(num);
                    tem = 0;
                }
            }
            if (list1.Count == list2.Count)
            {
                if (tem > 0)
                {
                    list.Add(tem);
                    tem = 0;
                }

            }
            if (list1.Count > list2.Count)
            {

                GetList(list2.Count, list1.Count, list, list1, ref tem);
            }
            if (list2.Count > list1.Count)
            {

                GetList(list1.Count, list2.Count, list, list2, ref tem);
            }
            if (tem > 0)
            {
                list.Add(tem);
                tem = 0;
            }

            ListNode nodep = null;
            ListNode fi = null;
            for (int i = 0; i < list.Count; i++)
            {
                ListNode node = new ListNode(list[i]);
                if (i == 0)
                {
                    fi = node;
                    nodep = node;
                }
                else
                {
                    nodep.next = node;
                    nodep = node;
                }
            }

            return fi;
        }
        private static void GetList(int begin, int end, List<int> list, List<int> arr, ref int tem)
        {
            for (int i = begin; i < end; i++)
            {
                int num = arr[i] + tem;
                tem = 0;
                if (num >= 10)
                {
                    tem = 1;
                }
                int mm = num % 10;
                list.Add(mm);
            }
        }
        private static List<int> GetArr(ListNode node)
        {
            List<int> list = new List<int>();
            list.Add(node.val);
            ListNode tem = node.next;
            while (tem != null)
            {
                list.Add(tem.val);
                tem = tem.next;
            }
            return list;
        }
    }
}
