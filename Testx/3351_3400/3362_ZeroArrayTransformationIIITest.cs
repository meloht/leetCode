using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3362_ZeroArrayTransformationIIITest
    {
        _3362_ZeroArrayTransformationIIIAlg alg = new _3362_ZeroArrayTransformationIIIAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [2, 0, 2];
            int[][] queries = [[0, 2], [0, 2], [1, 1]];
            int exp = 1;
            int res = alg.MaxRemoval(nums, queries);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 1, 1, 1];
            int[][] queries = [[1, 3], [0, 2], [1, 3], [1, 2]];
            int exp = 2;
            int res = alg.MaxRemoval(nums, queries);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [1, 2, 3, 4];
            int[][] queries = [[0, 3]];
            int exp = -1;
            int res = alg.MaxRemoval(nums, queries);
            Assert.Equal(exp, res);
        }
    }
}
