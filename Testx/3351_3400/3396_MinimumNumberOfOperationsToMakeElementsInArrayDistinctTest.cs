using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3396_MinimumNumberOfOperationsToMakeElementsInArrayDistinctTest
    {
        _3396_MinimumNumberOfOperationsToMakeElementsInArrayDistinctAlg alg = new _3396_MinimumNumberOfOperationsToMakeElementsInArrayDistinctAlg();
        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2, 3, 4, 2, 3, 3, 5, 7];
            int exp = 2;
            int res = alg.MinimumOperations(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [4, 5, 6, 4, 4];
            int exp = 2;
            int res = alg.MinimumOperations(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [6, 7, 8, 9];
            int exp = 0;
            int res = alg.MinimumOperations(nums);
            Assert.Equal(exp, res);
        }
    }
}
