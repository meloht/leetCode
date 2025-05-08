using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3342_FindMinimumTimeToReachLastRoomIITest
    {
        _3342_FindMinimumTimeToReachLastRoomIIAlg alg = new _3342_FindMinimumTimeToReachLastRoomIIAlg();

        [Fact]
        public void Test01()
        {
            int[][] moveTime = [[0, 4], [4, 4]];
            int exp = 7;
            int res = alg.MinTimeToReach(moveTime);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] moveTime = [[0, 0, 0, 0], [0, 0, 0, 0]];
            int exp = 6;
            int res = alg.MinTimeToReach(moveTime);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[][] moveTime = [[0, 1], [1, 2]];
            int exp = 4;
            int res = alg.MinTimeToReach(moveTime);
            Assert.Equal(exp, res);
        }
    }
}
