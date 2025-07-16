using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1027_LongestArithmeticSubsequenceTest
    {
        _1027_LongestArithmeticSubsequenceAlg alg = new _1027_LongestArithmeticSubsequenceAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [3, 6, 9, 12];
            int exp = 4;
            int res = alg.LongestArithSeqLength(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [9, 4, 7, 2, 10];
            int exp = 3;
            int res = alg.LongestArithSeqLength(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [20, 1, 15, 3, 10, 5, 8];
            int exp = 4;
            int res = alg.LongestArithSeqLength(nums);
            Assert.Equal(exp, res);
        }
    }
}
