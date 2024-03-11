using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _434_NumberOfSegmentsInAStringAlg
    {
        public int CountSegments(string s)
        {
            var num = s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;

            return num;
        }
    }
}
