using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1024_VideoStitchingAlg
    {
        public int VideoStitching(int[][] clips, int time)
        {
            int[] maxn = new int[time];
            int last = 0, ret = 0, pre = 0;
            foreach (int[] clip in clips)
            {
                if (clip[0] < time)
                {
                    maxn[clip[0]] = Math.Max(maxn[clip[0]], clip[1]);
                }
            }
            for (int i = 0; i < time; i++)
            {
                last = Math.Max(last, maxn[i]);
                if (i == last)
                {
                    return -1;
                }
                if (i == pre)
                {
                    ret++;
                    pre = last;
                }
            }
            return ret;

        }
    }
}
