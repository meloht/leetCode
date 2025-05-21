using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3356_ZeroArrayTransformationIITest
    {
        _3356_ZeroArrayTransformationIIAlg alg = new _3356_ZeroArrayTransformationIIAlg();
        [Fact]
        public void Test01()
        {
            int[] nums = [2, 0, 2];
            int[][] queries = [[0, 2, 1], [0, 2, 1], [1, 1, 3]];
            int exp = 2;
            int res = alg.MinZeroArray(nums, queries);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [4, 3, 2, 1];
            int[][] queries = [[1, 3, 2], [0, 2, 1]];
            int exp = -1;
            int res = alg.MinZeroArray(nums, queries);
            Assert.Equal(exp, res);
        }
    }
}
