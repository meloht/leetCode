using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3248_SnakeInMatrixAlg
    {
        public int FinalPositionOfSnake(int n, IList<string> commands)
        {
            int i = 0, j = 0;
            foreach (var item in commands)
            {
                if (item == "UP")
                {
                    i--;
                }
                else if (item == "RIGHT")
                {
                    j++;
                }
                else if (item == "LEFT")
                {
                    j--;
                }
                else if (item == "DOWN")
                {
                    i++;
                }
            }

            return i * n + j;
        }
    }
}
