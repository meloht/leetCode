using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1010_PairsOfSongsWithTotalDurationsDivisibleBy60Test
    {

        _1010_PairsOfSongsWithTotalDurationsDivisibleBy60Alg alg = new _1010_PairsOfSongsWithTotalDurationsDivisibleBy60Alg();
        [Fact]
        public void Test01()
        {
            int[] time = [30, 20, 150, 100, 40];
            int exp = 3;
            int res = alg.NumPairsDivisibleBy60(time);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] time = [60, 60, 60];
            int exp = 3;
            int res = alg.NumPairsDivisibleBy60(time);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] time = [15, 63, 451, 213, 37, 209, 343, 319];
            int exp = 1;
            int res = alg.NumPairsDivisibleBy60(time);
            Assert.Equal(exp, res);
        }
    }
}
