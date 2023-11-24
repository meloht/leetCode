using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _72_EditDistanceAlg
    {
        public int MinDistance(string word1, string word2)
        {
            string reversedKey = "";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < word2.Length; i++)
            {

            }

            HashSet<char> set = new HashSet<char>(word2);
            List<Node> list = new List<Node>();
            for (int i = 0; i < word1.Length; i++)
            {
                if (!set.Contains(word1[1]))
                {
                    list.Add(new Node(0, word1[i], -1));
                }
                else
                {
                    int index = word2.IndexOf(word1[i]);
                    if (index > 0)
                    {

                    }
                    list.Add(new Node(1, word1[i], index));
                }
            }



            return 0;
        }

        private Dictionary<string, int> GetReversedDict(string word1, string word2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            HashSet<char> set = new HashSet<char>(word2);
            
            List<char> list = new List<char>();
            foreach (char c in word1)
            {
                if (set.Contains(c))
                {
                    list.Add(c);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                
            }
            for (int i = 0; i < word2.Length; i++)
            {
               
            }
            return dict;
        }
        private string GetReStr(char c, List<char> list)
        {
            
        }
        class Node
        {
            public int flag;
            public char value;
            public int Index;
            public Node(int flag, char value, int index)
            {
                this.flag = flag;
                this.value = value;
                this.Index = index;
            }
        }
    }
}
