using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _794_ValidTicTacToeStateAlg
    {
        public bool ValidTicTacToe(string[] board)
        {
            int X = 0;
            int O = 0;
            int ansH = 0;
            int ansV = 0;
            int numX11 = 0;
            int numO11 = 0;

            int numX22 = 0;
            int numO22 = 0;
            int ansNumX = 0;
            int ansNumO = 0;
            for (int i = 0; i < 3; i++)
            {
                int numX = 0;
                int numO = 0;
                int numX1 = 0;
                int numO1 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        X++;
                        numX++;
                    }
                    else if (board[i][j] == 'O')
                    {
                        O++;
                        numO++;
                    }

                    if (board[j][i] == 'X')
                    {
                        numX1++;
                    }
                    else if (board[j][i] == 'O')
                    {
                        numO1++;
                    }
                }
                if (numO == 3 || numX == 3)
                {
                    ansH++;
                    if (numO == 3)
                    {
                        ansNumO++;
                    }
                    if (numX == 3)
                    {
                        ansNumX++;
                    }
                }
                if (numO1 == 3 || numX1 == 3)
                {
                    ansV++;
                    if (numO1 == 3)
                    {
                        ansNumO++;
                    }
                    if (numX1 == 3)
                    {
                        ansNumX++;
                    }
                }

                if (board[i][i] == 'X')
                {
                    numX11++;
                }
                else if (board[i][i] == 'O')
                {
                    numO11++;
                }
                if (board[2 - i][i] == 'X')
                {
                    numX22++;
                }
                else if (board[2 - i][i] == 'O')
                {
                    numO22++;
                }
            }

            if (numO11 == 3 || numX11 == 3)
            {
                if (numO11 == 3)
                {
                    ansNumO++;
                }
                if (numX11 == 3)
                {
                    ansNumX++;
                }
            }
            if (numO22 == 3 || numX22 == 3)
            {
                if (numO22 == 3)
                {
                    ansNumO++;
                }
                if (numX22 == 3)
                {
                    ansNumX++;
                }
            }

            if (X == 0 && O > 0)
                return false;

            if (O == 0 && X > 1)
                return false;

            if (O > 0 && X > 0 && !(X - O == 1 || X == O))
                return false;


            if (ansNumX > 0 && X == O)
                return false;

            if (ansNumO > 0 && X != O)
                return false;

            if (ansH <= 1 && ansV <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
