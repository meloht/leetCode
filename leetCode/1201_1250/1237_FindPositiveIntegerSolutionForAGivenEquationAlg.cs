using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1237_FindPositiveIntegerSolutionForAGivenEquationAlg
    {
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            IList<IList<int>> res = new List<IList<int>>();
            for (int x = 1; x <= 1000; x++)
            {
                int yleft = 1, yright = 1000;
                while (yleft <= yright)
                {
                    int ymiddle = (yleft + yright) / 2;
                    if (customfunction.f(x, ymiddle) == z)
                    {
                        res.Add(new List<int> { x, ymiddle });
                        break;
                    }
                    if (customfunction.f(x, ymiddle) > z)
                    {
                        yright = ymiddle - 1;
                    }
                    else
                    {
                        yleft = ymiddle + 1;
                    }
                }
            }
            return res;


        }

        public class CustomFunction
        {
            // Returns f(x, y) for any given positive integers x and y.
            // Note that f(x, y) is increasing with respect to both x and y.
            // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
            public int f(int x, int y) 
            {
                return 0;
            }
        }
    }
}
