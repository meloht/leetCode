using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374
    {
        public IList<int> FindPeaks(int[] mountain)
        {
            List<int> peak = new List<int>();


            for (int i = 1; i < mountain.Length - 1; i++)
            {
                int pre = mountain[i - 1];
                int num = mountain[i];
                int next = mountain[i + 1];
                if (num > pre && num > next)
                {
                    peak.Add(i);
                }
            }

            return peak;
        }

        public int MinimumAddedCoins(int[] coins, int target)
        {
            List<List<int>> listAll = GetAllList(coins);

            HashSet<int> list = new HashSet<int>();
            for (int i = 1; i <= 19; i++)
            {
                list.Add(i);
            }

            foreach (var item in listAll)
            {
                int num = item.Sum();
                list.Remove(num);
            }

            List<int> listDel = new List<int>();
            foreach (var item in list)
            {
                foreach (var item2 in listAll)
                {
                    int num = item2.Sum();

                }
            }
            foreach (int coin in coins)
            {

                foreach (int num in list)
                {
                    int dec = num % coin;
                    int count = num / coin;
                    if (dec == 0 && count > 0)
                    {
                        listDel.Add(num);
                    }
                }
                foreach (int item in listDel)
                {
                    listDel.Remove(item);
                }
                listDel.Clear();
            }
            listDel.Clear();
            foreach (int coin in coins)
            {
                foreach (int num in list)
                {
                    int dec = num % coin;
                    int count = num / coin;
                    if (dec > 0 && count > 0)
                    {
                        listDel.Add(num);
                    }
                }
            }







            return 0;
        }

        private List<List<int>> GetAllList(int[] coins)
        {
            List<List<int>> result = new List<List<int>>();
            GenerateSubsequences(coins, 0, new List<int>(), result);
            return result;
        }


        private void GenerateSubsequences(int[] arr, int index, List<int> current, List<List<int>> result)
        {
            if (index == arr.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            GenerateSubsequences(arr, index + 1, current, result);

            current.Add(arr[index]);
            GenerateSubsequences(arr, index + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }



        public int CountCompleteSubstrings(string word, int k)
        {
            if (word.Length == 1)
                return 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            List<char> list = new List<char>();
            List<List<char>> res = new List<List<char>>();
            int count = 0;
       
            int len = word.Length - 1;

            for (int i = 0; i< len; i++)
            {
                char curr = word[i];

                if (!dict.ContainsKey(curr))
                {
                    dict.Add(curr, 1);
                }
                else
                {
                    dict[curr]++;
                }
                if (dict[curr] == 2)
                {
                    if (list.Count > 1)
                    {
                        bool bl = Compute(list, dict);
                        if (bl)
                        {
                            count++;
                        }

                    }

                }
                if (dict[curr] > 2)
                {
                    int lastIndex = list.IndexOf(curr);
                    List<char> list2 = new List<char>();
                    for (int n = lastIndex; n < list.Count; n++)
                    {
                        list2.Add(list[n]);
                    }
                    list = list2;
                    dict[curr] = 2;
                    bool bl = Compute(list, dict);
                    if (bl)
                    {
                        count++;
                    }
                }

                char next = word[i + 1];
                if (Math.Abs(next - curr) <= 2)
                {
                    list.Add(curr);

                }
                if (list.Count > 1)
                {
                    bool bl = Compute(list, dict);
                    if (bl)
                    {
                        count++;
                    }


                }
            }


            return count;
        }

        private bool Compute(List<char> list, Dictionary<char, int> dict)
        {
            bool bl = true; ;
            foreach (char j in list)
            {
                if (dict[j] != 2)
                {
                    bl = false;
                }
            }
            return bl;
        }
        class NodeS
        {
            public char word;
            public int Index;
            public int Count;
        }
    }
}
