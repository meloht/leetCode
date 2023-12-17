using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _126_WordLadderIIAlg
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (!wordList.Contains(endWord))
                return res;

            List<int> lsIndex = new List<int>();
            for (int i = 0; i < beginWord.Length; i++)
            {
                if (beginWord[i] != endWord[i])
                {
                    lsIndex.Add(i);
                }
            }

            Dictionary<string, NodeData> dict = new Dictionary<string, NodeData>();

            DictInit(beginWord, lsIndex.ToArray(), endWord, new int[] { }, wordList.ToArray(), dict);

            if (dict.Count == 0)
                return res;



            return res;
        }

        private void DictInit(string beginWord, int[] lsIndex, string endWord, int[] lsIndexUsed, string[] words,
            Dictionary<string, NodeData> dict)
        {
            for (int i = 0; i < lsIndex.Length; i++)
            {
                var arr = lsIndexUsed.ToList();
                int index = lsIndex[i];
                char ch = endWord[index];
                arr.Add(index);
                arr.Sort();
                HashSet<int> list = new HashSet<int>(arr);
                List<string> listWord = new List<string>();
                foreach (var item in words)
                {
                    int count = 0;
                    for (int j = 0; j < beginWord.Length; j++)
                    {
                        bool bl11 = list.Contains(j);

                        if (bl11)
                        {
                            if (endWord[j] == item[j])
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (endWord[j] != item[j])
                            {
                                count++;
                            }
                        }
                    }
                    if (count == beginWord.Length)
                    {
                        string key = string.Join("-", arr);
                        if (!dict.ContainsKey(key))
                        {
                            dict.Add(key, new NodeData());
                            dict[key].Arr = new List<int>(arr);
                        }

                        dict[key].Words.Add(item);
                    }
                    else
                    {
                        listWord.Add(item);
                    }
                }
                if (listWord.Count < words.Length)
                {
                    var newArr = lsIndex.Where(p => p != index).ToArray();

                    DictInit(beginWord, newArr, endWord, arr.ToArray(), listWord.ToArray(), dict);
                }

            }
        }



        class NodeData
        {
            public List<int> Arr = new List<int>();
            public List<string> Words = new List<string>();

            public override string ToString()
            {
                return string.Join(",", Words);
            }

        }

    }
}
