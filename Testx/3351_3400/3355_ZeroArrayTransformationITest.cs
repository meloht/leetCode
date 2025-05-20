using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3355_ZeroArrayTransformationITest
    {
        _3355_ZeroArrayTransformationIAlg alg = new _3355_ZeroArrayTransformationIAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 0, 1];
            int[][] queries = [[0, 2]];
            bool exp = true;
            bool res = alg.IsZeroArray(nums, queries);
            Assert.Equal(exp,res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [4, 3, 2, 1];
            int[][] queries = [[1, 3], [0, 2]];
            bool exp = false;
            bool res = alg.IsZeroArray(nums, queries);
            Assert.Equal(exp, res);
        }
    }
}
