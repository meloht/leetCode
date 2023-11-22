using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _62_UniquePathsAlg
    {
        private int mMax = 0;
        private int nMax = 0;
        private int count = 0;
        public int UniquePaths1(int m, int n)
        {
            int[,] map = new int[m, n];
            mMax = m - 1;
            nMax = n - 1;
            SetWay(map, 0, 0);
            return count;
        }

        private void SetWay(int[,] map, int x, int y)
        {
            if (x == mMax && y == nMax)
            {
                count++;
                return;
            }
            else
            {
                if (x > mMax || y > nMax)
                    return;
                if (map[x, y] == 0)
                {
                    map[x, y] = 1;
                    SetWay(map, x + 1, y);
                    SetWay(map, x, y + 1);
                    map[x, y] = 0;
                }

            }
        }

        #region 动态规划



        public int UniquePaths(int m, int n)
        {
            Dictionary<string, MatrixModel> dict = new Dictionary<string, MatrixModel>();

            if (m < 2 || n < 2)
            {
                MatrixModel model = new MatrixModel(m, n);

                int[,] map = new int[m, n];
                SetPathWay(map, 0, 0, model);
                return model.Count;
            }
            for (int i = 2; i <= m; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    ComputeArr(i, j, dict);
                }
            }
            int num = dict[$"{m}-{n}"].Count;
            return num;
        }

        private void ComputeArr(int m, int n, Dictionary<string, MatrixModel> dict)
        {
            MatrixModel data = new MatrixModel(m, n);

            for (int i = 1; i <= m; i++)
            {
                string key = $"{i}-{n - 1}";
                if (!dict.ContainsKey(key))
                {
                    MatrixModel model = new MatrixModel(i, n - 1);
                    int[,] map = new int[model.M, model.N];
                    SetPathWay(map, 0, 0, model);
                    dict.Add(key, model);
                }

                data.Count += dict[key].Count;

            }
            dict.Add($"{m}-{n}", data);
        }
        private void SetPathWay(int[,] map, int x, int y, MatrixModel model)
        {
            if (x == model.EndX && y == model.EndY)
            {
                model.Count++;
                return;
            }
            else
            {
                if (x > model.EndX || y > model.EndY)
                    return;
                if (map[x, y] == 0)
                {
                    map[x, y] = 1;
                    SetPathWay(map, x + 1, y, model);
                    SetPathWay(map, x, y + 1, model);
                    map[x, y] = 0;
                }

            }
        }

        class MatrixModel
        {
            public int M { get; }
            public int N { get; }
            public int EndX { get; }
            public int EndY { get; }
            public int Count { get; set; }
            public MatrixModel(int x, int y)
            {
                M = x;
                N = y;
                EndX = x - 1;
                EndY = y - 1;
            }

        }

        #endregion

    }


}
