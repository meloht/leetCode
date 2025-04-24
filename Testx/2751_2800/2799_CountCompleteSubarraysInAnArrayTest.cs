using leetCode._2751_2800;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2751_2800
{
    public class _2799_CountCompleteSubarraysInAnArrayTest
    {
        _2799_CountCompleteSubarraysInAnArrayAlg alg = new _2799_CountCompleteSubarraysInAnArrayAlg();
        [Fact]
        public void Test1()
        {
            int[] nums = [1, 3, 1, 2, 2];
            int exp = 4;
            int res = alg.CountCompleteSubarrays(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [5, 5, 5, 5];
            int exp = 10;
            int res = alg.CountCompleteSubarrays(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [1898, 370, 822, 1659, 1360, 128, 370, 360, 261, 1898];
            int exp = 4;
            int res = alg.CountCompleteSubarrays(nums);
            Assert.Equal(exp, res);
        }
    }
}
