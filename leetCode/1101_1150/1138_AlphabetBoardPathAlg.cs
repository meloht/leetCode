using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1138_AlphabetBoardPathAlg
    {
        public string AlphabetBoardPath(string target)
        {
            var ans = new StringBuilder();
            int x = 0, y = 0;
            foreach (var c in target)
            {
                int nx = (c - 'a') / 5, ny = (c - 'a') % 5; // 目标位置
                var v = nx < x ? RepeatChar('U', x - nx) : RepeatChar('D', nx - x); // 竖直
                var h = ny < y ? RepeatChar('L', y - ny) : RepeatChar('R', ny - y); // 水平
                ans.Append(c != 'z' ? v + h : h + v).Append('!');
                x = nx;
                y = ny;
            }

            return ans.ToString();

        }
        private static string RepeatChar(char c, int count)
        {
            return count <= 0 ? "" : new string(c, count);
        }
    }
}
