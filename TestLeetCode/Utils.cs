using leetCode;
using leetCode._51_100;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Utils
    {

        /// <summary>
        /// 排序后比较
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static bool IsSame<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in list)
            {
                var ls1 = item.ToList();
                ls1.Sort();
                for (int i = 0; i < list2.Count; i++)
                {
                    if (set.Contains(i))
                        continue;
                    var item2 = list2[i];
                    if (item.Count != item2.Count)
                        continue;

                    var ls2 = item2.ToList();
                    ls2.Sort();
                    if (ls1.SequenceEqual(ls2))
                    {
                        count++;
                        set.Add(i);
                        break;
                    }
                }

            }
            if (count == list.Count)
                return true;
            return false;
        }
        /// <summary>
        /// 没有排序比较
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="list2"></param>
        /// <returns></returns>

        public static bool IsSameList<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in list)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (set.Contains(i))
                        continue;
                    var item2 = list2[i];

                    if (item.Count != item2.Count)
                        continue;

                    if (item.SequenceEqual(item2))
                    {
                        set.Add(i);
                        count++;
                        break;
                    }
                }
            }
            if (count == list.Count)
                return true;
            return false;
        }

        /// <summary>
        /// 严格相同
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
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

        public static bool IsSameArrNull(int?[][] arr1, int?[][] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == null && arr2[i] != null)
                {
                    return false;
                }
                if (arr1[i] == null)
                    continue;
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
        public static bool IsSameArr(char[][] arr1, char[][] arr2)
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

        /// <summary>
        /// 排序后相同
        /// </summary>
        /// <returns></returns>
        public static bool IsSameArr<T>(T[] arr1, T[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            return arr1.SequenceEqual(arr2);
        }
    }
}
