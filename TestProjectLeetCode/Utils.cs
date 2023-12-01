using leetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode
{
    public class Utils
    {
        public static ListNode BuildListNode(int[] arr)
        {
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
            }

            return header;
        }

        public static bool ListNodeSame(ListNode header, int[] arr)
        {
            List<int> list = new List<int>();
            ListNode node = header;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());
            return bl;
        }
        public static bool IsSame<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();
                b.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {
                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();
                    a.Sort();

                    if (a.SequenceEqual(b))
                    {
                        count++;

                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
            return false;
        }


        public static bool IsSameList<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();

                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {
                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();

                    if (a.SequenceEqual(b))
                    {
                        count++;
                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                        break;
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
            return false;
        }

        public static bool IsSameArr(int[][] arr1, int[][] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    if (arr1[i][j] != arr2[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
