using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0201_0250
{
    public class _212_WordSearchIIAlg
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            List<string> result = new List<string>();
            foreach (var item in words)
            {
                if (Exist(board, item))
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public bool Exist(char[][] board, string word)
        {
            List<int[]> list = new List<int[]>();
            char begin = word[0];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == begin)
                    {
                        list.Add(new[] { i, j });
                    }
                }
            }

            bool[,] used = new bool[board.Length, board[0].Length];
            foreach (var item in list)
            {
                bool bl = Dfs(board, item[0], item[1], word, 0, used);
                if (bl)
                {
                    return true;
                }
            }
            return false;
        }
        private bool Dfs(char[][] board, int i, int j, string word, int index, bool[,] used)
        {
            if (i >= board.Length || i < 0 || j >= board[0].Length || j < 0)
                return false;
            if (used[i, j] == true)
                return false;


            char ch = word[index];
            if (board[i][j] == ch)
            {

                if (index == word.Length - 1)
                {
                    return true;
                }
                index++;
                used[i, j] = true;
                bool bl = Dfs(board, i + 1, j, word, index, used);
                used[i, j] = false;
                if (bl == false)
                {
                    used[i, j] = true;
                    bl = Dfs(board, i, j + 1, word, index, used);
                    used[i, j] = false;
                    if (bl)
                    {
                        return true;
                    }
                    else
                    {
                        used[i, j] = true;
                        bl = Dfs(board, i - 1, j, word, index, used);
                        used[i, j] = false;
                        if (bl)
                        {
                            return true;
                        }
                        else
                        {
                            used[i, j] = true;
                            bl = Dfs(board, i, j - 1, word, index, used);
                            used[i, j] = false;
                            return bl;
                        }
                    }
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }



        public bool Exist1(char[][] board, string word)
        {
            int h = board.Length, w = board[0].Length;
            bool[,] visited = new bool[h, w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    bool flag = Check(board, visited, i, j, word, 0);
                    if (flag)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Check(char[][] board, bool[,] visited, int i, int j, string s, int k)
        {
            if (board[i][j] != s[k])
            {
                return false;
            }
            else if (k == s.Length - 1)
            {
                return true;
            }
            visited[i, j] = true;
            int[][] directions = [[0, 1], [0, -1], [1, 0], [-1, 0]];
            bool result = false;
            foreach (int[] dir in directions)
            {
                int newi = i + dir[0], newj = j + dir[1];
                if (newi >= 0 && newi < board.Length && newj >= 0 && newj < board[0].Length)
                {
                    if (!visited[newi,newj])
                    {
                        bool flag = Check(board, visited, newi, newj, s, k + 1);
                        if (flag)
                        {
                            result = true;
                            break;
                        }
                    }
                }
            }
            visited[i,j] = false;
            return result;
        }


    }
}
