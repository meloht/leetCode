using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1049_LastStoneWeightIITest
    {
        _1049_LastStoneWeightIIAlg alg = new _1049_LastStoneWeightIIAlg();

        [Fact]
        public void Test1()
        {
            int[] stones = [2, 7, 4, 1, 8, 1];
            int exp = 1;
            int res= alg.LastStoneWeightII(stones);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] stones = [31, 26, 33, 21, 40];
            int exp = 5;
            int res = alg.LastStoneWeightII(stones);
            Assert.Equal(exp, res);
        }
    }
}
