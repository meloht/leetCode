using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{
    public class _2545_SortTheStudentsByTheirKthScoreAlg
    {
        public int[][] SortTheStudents(int[][] score, int k)
        {
            Array.Sort(score, (x, y) => y[k].CompareTo(x[k]));
            return score;
        }
    }
}
