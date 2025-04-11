using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _912_SortAnArrayTest
    {
        _912_SortAnArrayAlg alg = new _912_SortAnArrayAlg();
        [Fact]
        public void Test01()
        {
            int[] nums = [5, 2, 3, 1];
            int[] exp = [1, 2, 3, 5];
            int[] res = alg.SortArray(nums);
            Assert.Equal(res, exp);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [5, 1, 1, 2, 0, 0];
            int[] exp = [0, 0, 1, 1, 2, 5];
            int[] res = alg.SortArray(nums);
            Assert.Equal(res, exp);
        }
    }
}
