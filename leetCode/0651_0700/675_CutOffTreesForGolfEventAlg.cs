using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _675_CutOffTreesForGolfEventAlg
    {
        int[][] dirs = [[-1, 0], [1, 0], [0, -1], [0, 1]];

        public int CutOffTree(IList<IList<int>> forest)
        {
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < forest.Count; i++)
            {
                for (int j = 0; j < forest[i].Count; j++)
                {
                    if (forest[i][j] > 1)
                    {
                        list.Add([forest[i][j], i, j]);
                    }
                }
            }
            list.Sort((x, y) => x[0] - y[0]);

            int startX = 0;
            int startY = 0;
            int ans = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                int steps = Astar(forest, startX, startY, item[1], item[2]);
                if (steps == -1)
                    return -1;

                ans += steps;
                startX = item[1];
                startY = item[2];
            }
            return ans;
        }

        public int Bfs(IList<IList<int>> forest, int startX, int startY, int targetX, int targetY)
        {
            if (startX == targetX && startY == targetY)
                return 0;

            int rows = forest.Count;
            int cols = forest[0].Count;
            int step = 0;
            Queue<int[]> queue = new Queue<int[]>();

            bool[,] visited = new bool[rows, cols];
            queue.Enqueue([startX, startY]);

            visited[startX, startY] = true;
            while (queue.Count > 0)
            {
                step++;
                int cnt = queue.Count;

                for (int i = 0; i < cnt; i++)
                {
                    var cell = queue.Dequeue();
                    int x = cell[0];
                    int y = cell[1];

                    foreach (var dir in dirs)
                    {
                        int nx = x + dir[0];
                        int ny = y + dir[1];
                        if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                        {
                            if (!visited[nx, ny] && forest[nx][ny] > 0)
                            {
                                if (nx == targetX && ny == targetY)
                                {
                                    return step;
                                }
                                queue.Enqueue([nx, ny]);
                                visited[nx, ny] = true;
                            }
                        }
                    }
                }
            }

            return -1;


        }

        public int Dijkstra(IList<IList<int>> forest, int startX, int startY, int targetX, int targetY)
        {
            if (startX == targetX && startY == targetY)
                return 0;

            int rows = forest.Count;
            int cols = forest[0].Count;

            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();

            bool[,] visited = new bool[rows, cols];
            queue.Enqueue([startX, startY, 0], 0);

            visited[startX, startY] = true;
            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();
                int x = cell[0];
                int y = cell[1];
                int dist = cell[2];

                foreach (var dir in dirs)
                {
                    int nx = x + dir[0];
                    int ny = y + dir[1];
                    if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                    {
                        if (!visited[nx, ny] && forest[nx][ny] > 0)
                        {
                            if (nx == targetX && ny == targetY)
                            {
                                return dist + 1;
                            }
                            queue.Enqueue([nx, ny, dist + 1], dist + 1);
                            visited[nx, ny] = true;
                        }
                    }
                }
            }

            return -1;
        }

        public int Astar(IList<IList<int>> forest, int startX, int startY, int targetX, int targetY)
        {
            if (startX == targetX && startY == targetY)
                return 0;

            int rows = forest.Count;
            int cols = forest[0].Count;
            int[,] costed = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    costed[i, j] = int.MaxValue;
                }
            }
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();
            costed[startX, startY] = Math.Abs(startX - targetX) + Math.Abs(startY - targetY);

            queue.Enqueue([startX, startY, 0], costed[startX, startY]);
            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();
                int x = cell[0];
                int y = cell[1];
                int dist = cell[2];
                if (x == targetX && y == targetY)
                {
                    return dist;
                }
                foreach (var dir in dirs)
                {
                    int nx = x + dir[0];
                    int ny = y + dir[1];
                    if (nx >= 0 && nx < rows && ny >= 0 && ny < cols && forest[nx][ny] > 0)
                    {
                        int ncost = dist + 1 + Math.Abs(nx - ny) + Math.Abs(startY - targetY);
                        if (ncost < costed[nx, ny])
                        {
                            queue.Enqueue([nx, ny, dist + 1], ncost);
                            costed[nx, ny] = ncost;
                        }

                    }
                }
            }

            return -1;
        }
    }
}
