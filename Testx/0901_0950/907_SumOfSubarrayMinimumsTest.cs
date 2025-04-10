using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _907_SumOfSubarrayMinimumsTest
    {
        _907_SumOfSubarrayMinimumsAlg alg = new _907_SumOfSubarrayMinimumsAlg();
        [Fact]
        public void Test01()
        {
            int[] arr = [3, 1, 2, 4];
            int exp = 17;
            int res = alg.SumSubarrayMins(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [11, 81, 94, 43, 3];
            int exp = 444;
            int res = alg.SumSubarrayMins(arr);
            Assert.Equal(exp, res);
        }
    }
}
