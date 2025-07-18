using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1031_MaximumSumOfTwoNonOverlappingSubarraysTest
    {
        _1031_MaximumSumOfTwoNonOverlappingSubarraysAlg alg = new _1031_MaximumSumOfTwoNonOverlappingSubarraysAlg();

        [Fact]
        public void TestCase01()
        {
            int[] nums = [0, 6, 5, 2, 2, 5, 1, 9, 4];
            int firstLen = 1, secondLen = 2;
            int exp = 20;
            int res=alg.MaxSumTwoNoOverlap(nums, firstLen, secondLen);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase02()
        {
            int[] nums = [3, 8, 1, 3, 2, 1, 8, 9, 0];
            int firstLen = 3, secondLen = 2;
            int exp = 29;
            int res = alg.MaxSumTwoNoOverlap(nums, firstLen, secondLen);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase03()
        {
            int[] nums = [2, 1, 5, 6, 0, 9, 5, 0, 3, 8];
            int firstLen = 4, secondLen = 3;
            int exp = 31;
            int res = alg.MaxSumTwoNoOverlap(nums, firstLen, secondLen);
            Assert.Equal(exp, res);
        }
    }
}
