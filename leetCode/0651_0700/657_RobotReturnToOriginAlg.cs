using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _657_RobotReturnToOriginAlg
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            foreach (var move in moves)
            {
                if (move == 'U')
                {
                    y++;
                }
                else if (move == 'D')
                {
                    y--;
                }
                else if (move == 'R')
                {
                    x++;
                }
                else if (move == 'L')
                {
                    x--;
                }
            }
            return x == 0 && y == 0;
        }
    }
}
