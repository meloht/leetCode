using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0701_0750._705_DesignHashsetAlg;

namespace leetCode._0851_0900
{
    public class _874_WalkingRobotSimulationAlg
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
            foreach (int[] item in obstacles)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]].Add(item[1]);
                }
                else
                {
                    HashSet<int> set = new HashSet<int>();
                    set.Add(item[1]);
                    dict.Add(item[0], set);
                }

            }

            int x = 0, y = 0;
            char direction = 'N';//E S W N
            int ans = 0;
            foreach (int cmd in commands)
            {
                if (cmd == -2)
                {
                    switch (direction)
                    {
                        case 'N':
                            direction = 'W';
                            break;
                        case 'E':
                            direction = 'N';
                            break;
                        case 'W':
                            direction = 'S';
                            break;
                        case 'S':
                            direction = 'E';
                            break;
                    }
                }
                else if (cmd == -1)
                {
                    switch (direction)
                    {
                        case 'N':
                            direction = 'E';
                            break;
                        case 'E':
                            direction = 'S';
                            break;
                        case 'W':
                            direction = 'N';
                            break;
                        case 'S':
                            direction = 'W';
                            break;
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 'N':
                            int nn = y + cmd;
                            for (int i = y + 1; i <= nn; i++)
                            {
                                if (dict.ContainsKey(x) && dict[x].Contains(i))
                                {
                                    break;
                                }
                                y = i;
                            }

                            break;
                        case 'E':
                            int nn1 = x + cmd;
                            for (int i = x + 1; i <= nn1; i++)
                            {
                                if (dict.ContainsKey(i) && dict[i].Contains(y))
                                {
                                    break;
                                }
                                x = i;
                            }
                            break;
                        case 'W':
                            int nn2 = x - cmd;
                            for (int i = x - 1; i >= nn2; i--)
                            {
                                if (dict.ContainsKey(i) && dict[i].Contains(y))
                                {
                                    break;
                                }
                                x = i;
                            }
                            break;
                        case 'S':
                            int nn3 = y - cmd;
                            for (int i = y - 1; i >= nn3; i--)
                            {
                                if (dict.ContainsKey(x) && dict[x].Contains(i))
                                {
                                    break;
                                }
                                y = i;
                            }
                            break;
                    }

                    ans = Math.Max(x * x + y * y, ans);
                }
            }

            return ans;
        }
    }
}
