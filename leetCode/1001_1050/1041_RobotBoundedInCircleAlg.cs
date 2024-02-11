using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1041_RobotBoundedInCircleAlg
    {
        public bool IsRobotBounded1(string instructions)
        {

            HashSet<string> set = new HashSet<string>();
            int n = 10;
            int direction = 3;
            int x = 0;
            int y = 0;
            while (n > 0)
            {
                string key = $"{x}_{y}";
                if (set.Contains(key))
                    return true;
                set.Add(key);
                foreach (var ch in instructions)
                {
                    if (ch == 'G')
                    {
                        if (direction == 3)
                        {
                            y++;
                        }
                        else if (direction == 2)
                        {
                            y--;
                        }
                        else if (direction == -1)
                        {
                            x--;
                        }
                        else if (direction == 1)
                        {
                            x++;
                        }

                    }
                    else if (ch == 'L')
                    {
                        switch (direction)
                        {
                            case -1:
                                direction = 2;
                                break;
                            case 1:
                                direction = 3;
                                break;
                            case 2:
                                direction = 1;
                                break;
                            case 3:
                                direction = -1;
                                break;
                            default:
                                break;
                        }
                    }
                    else if (ch == 'R')
                    {
                        switch (direction)
                        {
                            case -1:
                                direction = 3;
                                break;
                            case 1:
                                direction = 2;
                                break;
                            case 2:
                                direction = -1;
                                break;
                            case 3:
                                direction = 1;
                                break;
                            default:
                                break;
                        }
                    }


                }
                n--;
            }

            return false;
        }

        public bool IsRobotBounded(string instructions)
        {
            int[][] direc = [[0, 1], [1, 0], [0, -1], [-1, 0]];

            int direcIndex = 0;
            int x = 0, y = 0;

            foreach (var instruction in instructions)
            {
                if (instruction == 'G')
                {
                    x += direc[direcIndex][0];
                    y += direc[direcIndex][1];
                }
                else if (instruction == 'L')
                {
                    direcIndex += 3;
                    direcIndex %= 4;
                }
                else
                {
                    direcIndex++;
                    direcIndex %= 4;
                }
            }
          
            return direcIndex != 0 || (x == 0 && y == 0);

        }
    }
}
