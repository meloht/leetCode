using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3001_MinimumMovesToCaptureTheQueenAlg
    {
        public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f)
        {
            // 车与皇后处在同一行，且中间没有象
            if (a == e && (c != a || d <= Math.Min(b, f) || d >= Math.Max(b, f)))
            {
                return 1;
            }
            // 车与皇后处在同一列，且中间没有象
            if (b == f && (d != b || c <= Math.Min(a, e) || c >= Math.Max(a, e)))
            {
                return 1;
            }
            // 象、皇后处在同一条对角线，且中间没有车
            if (Math.Abs(c - e) == Math.Abs(d - f) && ((c - e) * (b - f) != (a - e) * (d - f)
                || a < Math.Min(c, e) || a > Math.Max(c, e)))
            {
                return 1;
            }
            return 2;
        }


    }
}
