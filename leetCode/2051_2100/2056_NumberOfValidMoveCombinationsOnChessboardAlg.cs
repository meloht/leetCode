using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2051_2100
{
    public class _2056_NumberOfValidMoveCombinationsOnChessboardAlg
    {
      
        public int CountCombinations(string[] pieces, int[][] positions)
        {
            Dictionary<char, int[][]> PIECE_DIRS = new Dictionary<char, int[][]>();
            PIECE_DIRS.Add('r', [[-1, 0], [1, 0], [0, -1], [0, 1]]);
            PIECE_DIRS.Add('b', [[1, 1], [-1, 1], [-1, -1], [1, -1]]);
            PIECE_DIRS.Add('q', [[-1, 0], [1, 0], [0, -1], [0, 1], [1, 1], [-1, 1], [-1, -1], [1, -1]]);
            int n = pieces.Length;
            // 预处理所有合法移动
            Move[][] allMoves = new Move[n][];
            for (int i = 0; i < n; i++)
            {
                allMoves[i] = generateMoves(positions[i][0], positions[i][1], PIECE_DIRS[pieces[i][0]]);
            }

            Move[] path = new Move[n]; // 注意 path 的长度是固定的
            return dfs(0, n, allMoves, path);

        }

        // 计算位于 (x0,y0) 的棋子在 dirs 这些方向上的所有合法移动
        private Move[] generateMoves(int x0, int y0, int[][] dirs)
        {
            int SIZE = 8;
            List<Move> moves = new List<Move>();
            moves.Add(new Move(x0, y0, 0, 0, 0)); // 原地不动
            foreach (int[] d in dirs)
            {
                // 往 d 方向走 1,2,3,... 步
                int x = x0 + d[0], y = y0 + d[1];
                for (int step = 1; 0 < x && x <= SIZE && 0 < y && y <= SIZE; step++)
                {
                    moves.Add(new Move(x0, y0, d[0], d[1], step));
                    x += d[0];
                    y += d[1];
                }
            }
            return moves.ToArray();
        }


        // 判断两个移动是否合法，即不存在同一时刻两个棋子重叠的情况
        private bool isValid(Move m1, Move m2)
        {
            int x1 = m1.x0, y1 = m1.y0; // 初始位置
            int x2 = m2.x0, y2 = m2.y0;
            for (int i = 0; i < Math.Max(m1.step, m2.step); i++)
            {
                // 每一秒走一步
                if (i < m1.step)
                {
                    x1 += m1.dx;
                    y1 += m1.dy;
                }
                if (i < m2.step)
                {
                    x2 += m2.dx;
                    y2 += m2.dy;
                }
                if (x1 == x2 && y1 == y2)
                { // 重叠
                    return false;
                }
            }
            return true;
        }
        private int dfs(int i, int n, Move[][] allMoves, Move[] path)
        {
            if (i == n)
            {
                return 1;
            }
            int res = 0;

            // 枚举当前棋子的所有合法移动
            foreach (Move move1 in allMoves[i])
            {
                // 判断合法移动 move1 是否有效
                bool ok = true;
                for (int j = 0; j < i; j++)
                {
                    if (!isValid(move1, path[j]))
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    path[i] = move1; // 直接覆盖，无需恢复现场
                    res += dfs(i + 1, n, allMoves, path); // 枚举后续棋子的所有合法移动组合
                }

            }
            return res;
        }


        private record Move(int x0, int y0, int dx, int dy, int step)
        {
        }
    }
}
