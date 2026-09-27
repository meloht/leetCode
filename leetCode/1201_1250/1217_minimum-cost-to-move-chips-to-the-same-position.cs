using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1201_1250
{
    public class _1217_minimum_cost_to_move_chips_to_the_same_position
    {
        public int MinCostToMoveChips(int[] position)
        {

            int n1 = 0;
            int n2 = 0;
            foreach (var item in position)
            {

                if (item % 2 == 0)
                {
                    n2++;
                }
                else
                {
                    n1++;
                }
            }
            if (n1 > n2)
            {
                return n2;
            }
            return n1;

        }
    }
}
