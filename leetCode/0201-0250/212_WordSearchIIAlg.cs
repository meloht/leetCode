﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace leetCode._0201_0250
{
    public class _212_WordSearchIIAlg
    {

        int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
        public IList<string> FindWords1(char[][] board, string[] words)
        {
            TrieNode root = new TrieNode();
            foreach (var item in words)
            {
                root.Insert(item);
            }

            HashSet<string> ans = new HashSet<string>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    DFS(board, i, j, root, ans);
                }
            }
            return ans.ToList();
        }

        private void DFS(char[][] board, int i, int j, TrieNode node, HashSet<string> ans)
        {
            if (board[i][j] == '#')
                return;
            int index = board[i][j] - 'a';
            if (node.Children[index] == null)
            {
                return;
            }
            char ch = board[i][j];
            var nxt = node.Children[index];

            if (nxt.Word != "")
            {
                ans.Add(nxt.Word);
                nxt.Word = "";
            }
            if (nxt.Children.Count(p => p != null) > 0)
            {
                board[i][j] = '#';
                int len = directions.GetLength(0);
                for (int k = 0; k < len; k++)
                {
                    int ii = i + directions[k, 0];
                    int jj = j + directions[k, 1];
                    if (ii >= 0 && ii < board.Length && jj >= 0 && jj < board[0].Length)
                    {
                        DFS(board, ii, jj, nxt, ans);
                    }
                }
                board[i][j] = ch;
            }
            if (nxt.Children.Count(p => p != null) == 0)
            {
                node.Children[index] = null;
            }

        }

        class TrieNode
        {
            public string Word = "";
            public TrieNode[] Children = new TrieNode[26];
            public bool IsWord;

            public void Insert(string word)
            {
                TrieNode node = this;
                foreach (var ch in word)
                {
                    int index = ch - 'a';
                    if (node.Children[index] == null)
                    {
                        node.Children[index] = new TrieNode();
                    }
                    node = node.Children[index];
                }
                node.Word = word;
            }

        }


        public IList<string> FindWords2(char[][] board, string[] words)
        {
            int[,] tree = new int[10001, 26];
            int[] pass = new int[10001];
            string[] end = new string[10001];
            int index = 1;
            //静态前缀树
            for (int i = 0; i < words.Length; i++)
            {
                var curent = 1;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (tree[curent, words[i][j] - 'a'] == 0)
                    {
                        tree[curent, words[i][j] - 'a'] = ++index;
                    }
                    curent = tree[curent, words[i][j] - 'a'];
                    pass[curent]++;
                }
                end[curent] = words[i];
            }
            int n = board.Length;
            int m = board[0].Length;
            List<string> ans = new List<string>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dfs(i, j, 1);
                }
            }
            return ans;
            //返回：收集到了几个答案
            int dfs(int i, int j, int start)
            {
                if (i < 0 || i >= n || j < 0 || j >= m || board[i][j] == ' ')
                    return 0;
                int count = 0;
                int next = tree[start, board[i][j] - 'a'];
                if (end[next] != null)
                {
                    ans.Add(end[next]);
                    end[next] = null;
                    count++;
                }
                var temp = board[i][j];
                board[i][j] = ' ';
                if (next != 0 && pass[next] > 0)
                {
                    count += dfs(i - 1, j, next);
                    count += dfs(i + 1, j, next);
                    count += dfs(i, j - 1, next);
                    count += dfs(i, j + 1, next);
                }
                board[i][j] = temp;
                pass[next] -= count;
                return count;
            }

        }


        public IList<string> FindWords(char[][] board, string[] words)
        {
            WordDictionary dic = new WordDictionary(), t;
            foreach (var word in words)
            {
                t = dic;
                foreach (var c in word)
                {
                    if (t[c] == null) t[c] = new WordDictionary();
                    t = t[c];
                }
                t.word = word;
            }

            int m = board.Length - 1, n = board[0].Length - 1;
            var result = new List<string>();
            void searchWords(int i, int j, WordDictionary tmp)
            {
                char c;
                if ((c = board[i][j]) == '#' || tmp[c] == null) return;

                tmp = tmp[c];
                if (tmp.word != null)
                {
                    result.Add(tmp.word);
                    tmp.word = null;
                }

                if (!tmp.hashNext) return;

                board[i][j] = '#';
                if (i < m) searchWords(i + 1, j, tmp);
                if (i > 0) searchWords(i - 1, j, tmp);
                if (j < n) searchWords(i, j + 1, tmp);
                if (j > 0) searchWords(i, j - 1, tmp);
                board[i][j] = c;
            }

            for (var i = 0; i <= m; i++)
                for (var j = 0; j <= n; j++)
                    searchWords(i, j, dic);
            return result;
        }

        private class WordDictionary
        {
            public WordDictionary[] next = new WordDictionary[26];
            public string word;
            public bool hashNext = false;
            public WordDictionary this[char c]
            {
                get
                {
                    return next[c - 'a'];
                }
                set
                {
                    next[c - 'a'] = value;
                    hashNext = true;
                }
            }
        }
    }
}
