using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1276_number_of_burgers_with_no_waste_of_ingredients
    {
        public IList<int> NumOfBurgers1(int tomatoSlices, int cheeseSlices)
        {
            int a = 0;
            int b = 0;
            if (tomatoSlices == 0 && cheeseSlices == 0)
                return [0, 0];
            for (int i = 0; i < cheeseSlices; i++)
            {
                a = i;
                b = cheeseSlices - a;
                if (a * 4 + b * 2 == tomatoSlices)
                {
                    return [a, b];
                }
            }
            return [];
        }

        public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices)
        {
            if (tomatoSlices % 2 != 0 || tomatoSlices < cheeseSlices * 2 || cheeseSlices * 4 < tomatoSlices)
            {
                return new List<int>();
            }
            IList<int> ans = new List<int>();
            ans.Add(tomatoSlices / 2 - cheeseSlices);
            ans.Add(cheeseSlices * 2 - tomatoSlices / 2);
            return ans;

        }
    }
}
