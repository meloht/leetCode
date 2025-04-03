using leetCode._0851_0900;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _873_LengthOfLongestFibonacciSubsequenceTest
    {
        _873_LengthOfLongestFibonacciSubsequenceAlg alg = new _873_LengthOfLongestFibonacciSubsequenceAlg();
        [Fact]
        public void Test01()
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
            int exp = 5;
            int res = alg.LenLongestFibSubseq(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [1, 3, 7, 11, 12, 14, 18];
            int exp = 3;
            int res = alg.LenLongestFibSubseq(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] arr = [2, 4, 5, 6, 7, 8, 11, 13, 14, 15, 21, 22, 34];
            int exp = 5;
            int res = alg.LenLongestFibSubseq(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] arr = [1, 2, 3, 6, 7, 8, 9, 10, 12, 14, 21, 33];
            int exp = 5;
            int res = alg.LenLongestFibSubseq(arr);
            Assert.Equal(exp, res);
        }
    }
}
