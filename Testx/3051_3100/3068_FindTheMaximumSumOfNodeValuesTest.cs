using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3051_3100
{
    public class _3068_FindTheMaximumSumOfNodeValuesTest
    {
        _3068_FindTheMaximumSumOfNodeValuesAlg alg = new _3068_FindTheMaximumSumOfNodeValuesAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 2, 1];
            int k = 3;
            int[][] edges = [[0, 1], [0, 2]];
            long exp = 6;
            long res = alg.MaximumValueSum(nums, k, edges);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [2, 3];
            int k = 7;
            int[][] edges = [[0, 1]];
            long exp = 9;
            long res = alg.MaximumValueSum(nums, k, edges);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [7, 7, 7, 7, 7, 7];
            int k = 3;
            int[][] edges = [[0, 1], [0, 2], [0, 3], [0, 4], [0, 5]];
            long exp = 42;
            long res = alg.MaximumValueSum(nums, k, edges);
            Assert.Equal(exp, res);
        }
    }
}
