using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class WordModel
    {
        public int Index;
        public string Word;
        public bool IsUse;

        public override string ToString()
        {
            return $"{Index} {Word} {IsUse}";
        }
    }

    public class SubstringWithConcatenationOfAllWords
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> res = new List<int>();
            int m = words.Length, n = words[0].Length, ls = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (i + m * n > ls)
                {
                    break;
                }
                Dictionary<string, int> differ = new Dictionary<string, int>();
                for (int j = 0; j < m; j++)
                {
                    string word = s.Substring(i + j * n, n);
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]++;
                }
                foreach (string word in words)
                {
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]--;
                    if (differ[word] == 0)
                    {
                        differ.Remove(word);
                    }
                }
                for (int start = i; start < ls - m * n + 1; start += n)
                {
                    if (start != i)
                    {
                        string word = s.Substring(start + (m - 1) * n, n);
                        if (!differ.ContainsKey(word))
                        {
                            differ.Add(word, 0);
                        }
                        differ[word]++;
                        if (differ[word] == 0)
                        {
                            differ.Remove(word);
                        }
                        word = s.Substring(start - n, n);
                        if (!differ.ContainsKey(word))
                        {
                            differ.Add(word, 0);
                        }
                        differ[word]--;
                        if (differ[word] == 0)
                        {
                            differ.Remove(word);
                        }
                    }
                    if (differ.Count == 0)
                    {
                        res.Add(start);
                    }
                }
            }
            return res;
        }
        public IList<int> FindSubstring3(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (string.IsNullOrEmpty(s))
                return result;
            if (words == null || words.Length == 0)
                return result;


            int len = words.Length;
            int wordLen = words[0].Length;

            if (s.Length < len * wordLen)
            {
                return result;
            }
            int slen = s.Length;

            int subLen = len * wordLen;

            var list = getWordList(words);
            var dict = getSubDict(list);

            int n = 0;
            string sub = s;
            bool flag = false;
            bool flagIn = false;

            while (n < slen)
            {

                foreach (var item in list)
                {
                    if (!sub.StartsWith(item.Word))
                    {
                        continue;
                    }

                    string start = item.Word;
                    var ls = dict[item.Index];

                    HashSet<WordModel> strings = new HashSet<WordModel>(ls);
                    while (true)
                    {
                        flagIn = false;
                        List<WordModel> removeList = new List<WordModel>();

                        if (strings.Count > 0)
                        {

                            foreach (var item2 in strings)
                            {
                                var tempIn = item2;
                                var tempStart = $"{start}{item2.Word}";
                                if (sub.StartsWith(tempStart))
                                {
                                    start = tempStart;
                                    flagIn = true;
                                    removeList.Add(item2);
                                }
                            }
                            foreach (var item3 in removeList)
                            {
                                strings.Remove(item3);
                            }

                        }

                        if (start.Length == subLen && sub.StartsWith(start))
                        {
                            flag = true;
                            result.Add(n);
                            break;

                        }
                        if (strings.Count == 0 || flagIn == false)
                        {
                            break;
                        }

                    }

                    if (flag)
                    {
                        break;
                    }
                }

                n++;
                flag = false;
                sub = s.Substring(n);
                if (sub.Length < subLen)
                {
                    break;
                }
            }

            return result;
        }
        public IList<int> FindSubstring2(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (string.IsNullOrEmpty(s))
                return result;
            if (words == null || words.Length == 0)
                return result;


            int len = words.Length;
            int wordLen = words[0].Length;

            if (s.Length < len * wordLen)
            {
                return result;
            }
            int slen = s.Length;

            int subLen = len * wordLen;

            var list = getWordList(words);

            int n = 0;
            string sub = s;
            bool flag = false;
            bool flagIn = false;
            int arrLen;
            while (n < slen)
            {

                foreach (var item in list)
                {
                    if (!sub.StartsWith(item.Word))
                    {
                        continue;
                    }

                    string start = item.Word;
                    var tempOut = item;

                    while (sub.StartsWith(start))
                    {
                        flagIn = false;
                        tempOut.IsUse = true;
                        var reList = list.Where(item => item.IsUse == false).ToList();
                        arrLen = reList.Count;
                        if (arrLen > 0)
                        {
                            for (int i = 0; i < arrLen; i++)
                            {
                                var tempIn = reList[i];
                                var tempStart = $"{start}{tempIn.Word}";
                                if (sub.StartsWith(tempStart))
                                {
                                    start = tempStart;
                                    tempIn.IsUse = true;
                                    flagIn = true;
                                }

                            }

                        }


                        if (start.Length == subLen && sub.StartsWith(start))
                        {
                            flag = true;
                            result.Add(n);
                            break;

                        }
                        if (reList.Count == 0 || flagIn == false)
                        {
                            break;
                        }

                    }
                    RestList(list);

                    if (flag)
                    {
                        break;
                    }
                }

                n++;
                flag = false;
                sub = s.Substring(n);
                if (sub.Length < subLen)
                {
                    break;
                }
            }

            return result;
        }

        private Dictionary<int, List<WordModel>> getSubDict(List<WordModel> words)
        {
            Dictionary<int, List<WordModel>> dict = new Dictionary<int, List<WordModel>>();
            for (int i = 0; i < words.Count; i++)
            {
                List<WordModel> ls = new List<WordModel>(words);
                ls.RemoveAt(i);
                dict.Add(i, ls);

            }

            return dict;
        }
        private void RestList(List<WordModel> list)
        {
            foreach (var item in list)
            {
                item.IsUse = false;
            }
        }

        private List<WordModel> getWordList(string[] words)
        {
            List<WordModel> list = new List<WordModel>();
            for (int i = 0; i < words.Length; i++)
            {
                WordModel model = new WordModel();
                model.Word = words[i];
                model.Index = i;
                model.IsUse = false;
                list.Add(model);
            }

            return list;
        }
        
    }
}
