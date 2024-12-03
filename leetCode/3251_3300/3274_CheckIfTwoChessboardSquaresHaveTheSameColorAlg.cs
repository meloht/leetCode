using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3274_CheckIfTwoChessboardSquaresHaveTheSameColorAlg
    {
        public bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            int col1 = coordinate1[0] - 'a';
            int row1 = coordinate1[1] - '1';

            int col2 = coordinate2[0] - 'a';
            int row2 = coordinate2[1] - '1';

            if (IsBlack(row1, col1) == IsBlack(row2, col2))
            {
                return true;
            }

            return false;
        }
        private bool IsBlack(int row,int col) 
        {
            if (row % 2 == 0 && col % 2 == 0)
            {
                return false;
            }
            if (row % 2 == 1 && col % 2 == 0)
            {
                return true;
            }
            if (row % 2 == 0 && col % 2 == 1)
            {
                return true;
            }
            if (row % 2 == 1 && col % 2 == 1)
            {
                return false;
            }

            return false;

        }
    }
}
