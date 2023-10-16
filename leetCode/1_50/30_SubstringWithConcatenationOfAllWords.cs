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
