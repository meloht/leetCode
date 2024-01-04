using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
