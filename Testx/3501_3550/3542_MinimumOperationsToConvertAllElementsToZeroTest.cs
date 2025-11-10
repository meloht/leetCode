using leetCode._3501_3550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3501_3550
{
    public class _3542_MinimumOperationsToConvertAllElementsToZeroTest
    {
        _3542_MinimumOperationsToConvertAllElementsToZeroAlg alg = new _3542_MinimumOperationsToConvertAllElementsToZeroAlg();

        [Fact]
        public void Test1()
        {
            int[] nums = [0, 2];
            int exp = 1;
            int res = alg.MinOperations(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [3, 1, 2, 1];
            int exp = 3;
            int res = alg.MinOperations(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [1, 2, 1, 2, 1, 2];
            int exp = 4;
            int res = alg.MinOperations(nums);
            Assert.Equal(exp, res);
        }
    }
}
