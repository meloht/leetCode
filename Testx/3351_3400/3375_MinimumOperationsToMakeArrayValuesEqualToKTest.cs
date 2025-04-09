using leetCode._3351_3400;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3375_MinimumOperationsToMakeArrayValuesEqualToKTest
    {
        _3375_MinimumOperationsToMakeArrayValuesEqualToKAlg alg = new _3375_MinimumOperationsToMakeArrayValuesEqualToKAlg();
        
        [Fact]
        public void Test01()
        {
            int[] nums = [5, 2, 5, 4, 5];
            int k = 2;
            int exp = 2;
            int res = alg.MinOperations(nums, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [2, 1, 2];
            int k = 2;
            int exp = -1;
            int res = alg.MinOperations(nums, k);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test03()
        {
            int[] nums = [9, 7, 5, 3];
            int k = 1;
            int exp = 4;
            int res = alg.MinOperations(nums, k);
            Assert.Equal(exp, res);
        }
    }
}
