using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1033_MovingStonesUntilConsecutiveTest
    {
        _1033_MovingStonesUntilConsecutiveAlg alg = new _1033_MovingStonesUntilConsecutiveAlg();

        [Fact]
        public void TestCase01()
        {
            int a = 1, b = 2, c = 5;
            int[] exp = [1, 2];
            int[] res=alg.NumMovesStones(a, b, c);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase02()
        {
            int a = 4, b = 3, c = 2;
            int[] exp = [0, 0];
            int[] res = alg.NumMovesStones(a, b, c);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase03()
        {
            int a = 3, b = 5, c = 1;
            int[] exp = [1, 2];
            int[] res = alg.NumMovesStones(a, b, c);
            Assert.Equal(exp, res);
        }
    }
}
