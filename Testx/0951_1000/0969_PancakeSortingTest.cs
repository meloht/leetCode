using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0969_PancakeSortingTest
    {
        _0969_PancakeSortingAlg alg = new _0969_PancakeSortingAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [3, 2, 4, 1];
            int[] exp = [3, 4, 2, 3, 2];
          
            int[] res = alg.PancakeSort(nums).ToArray();
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 2, 3];
            int[] exp = [];
            int[] res = alg.PancakeSort(nums).ToArray();
            Assert.Equal(exp, res);
        }
    }
}
