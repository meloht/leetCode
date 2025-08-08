using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1040_MovingStonesUntilConsecutiveIITest
    {
        _1040_MovingStonesUntilConsecutiveIIAlg alg = new _1040_MovingStonesUntilConsecutiveIIAlg();

        [Fact]
        public void Test1()
        {
            int[] stones=[7, 4, 9];
            int[] exp = [1, 2];
            int[] res = alg.NumMovesStonesII(stones);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] stones = [6, 5, 4, 3, 10];
            int[] exp = [2, 3];
            int[] res = alg.NumMovesStonesII(stones);
            Assert.Equal(exp, res);
        }
    }
}
