using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1801_1850
{
    public class _1812_DetermineColorOfAChessboardSquareAlg
    {
        public bool SquareIsWhite(string coordinates)
        {
            int col = coordinates[0] - 'a';
            int row = coordinates[1] - '1';
            if (col % 2 != row % 2)
            {
                return true;
            }
            return false;
        }
    }
}
