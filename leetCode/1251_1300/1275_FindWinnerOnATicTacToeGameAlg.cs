using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1275_FindWinnerOnATicTacToeGameAlg
    {
        public string Tictactoe(int[][] moves)
        {
            int[] a1 = new int[3];
            int[] a2 = new int[3];

            int[] b1 = new int[3];
            int[] b2 = new int[3];
            int numA = 0; int numB = 0;
            int numA1 = 0; int numB1 = 0;
            int m = moves.Length;


            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    a1[moves[i][0]]++;
                    a2[moves[i][1]]++;

                    if (a2[moves[i][1]] == 3 || a1[moves[i][0]] == 3)
                    {
                        return "A";
                    }
                    if (moves[i][0] == moves[i][1])
                    {
                        numA++;
                    }
                    if (moves[i][0] + moves[i][1] == 2)
                    {
                        numA1++;
                    }
                    if (numA == 3 || numA1 == 3)
                    {
                        return "A";
                    }
                }
                else
                {
                    b1[moves[i][0]]++;
                    b2[moves[i][1]]++;
                    if (b1[moves[i][0]] == 3 || b2[moves[i][1]] == 3)
                    {
                        return "B";
                    }
                    if (moves[i][0] == moves[i][1])
                    {
                        numB++;
                    }
                    if (moves[i][0] + moves[i][1] == 2)
                    {
                        numB1++;
                    }
                    if (numB == 3 || numB1 == 3)
                    {
                        return "B";
                    }

                }
            }
            if (moves.Length == 9)
            {
                return "Draw";
            }

            return "Pending";
        }

    }
}
