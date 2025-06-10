using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1024_VideoStitchingTest
    {
        _1024_VideoStitchingAlg alg = new _1024_VideoStitchingAlg();

        [Fact]
        public void Test01()
        {
            int[][] clips = [[0, 2], [4, 6], [8, 10], [1, 9], [1, 5], [5, 9]];
            int time = 10;
            int exp = 3;
            int res = alg.VideoStitching(clips, time);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] clips = [[0, 2], [4, 6], [8, 10], [1, 9], [1, 5], [5, 9]];
            int time = 10;
            int exp = 3;
            int res = alg.VideoStitching(clips, time);
            Assert.Equal(exp, res);
        }
    }
}
