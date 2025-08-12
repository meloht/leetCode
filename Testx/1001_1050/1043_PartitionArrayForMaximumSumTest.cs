using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1043_PartitionArrayForMaximumSumTest
    {
        _1043_PartitionArrayForMaximumSumAlg alg = new _1043_PartitionArrayForMaximumSumAlg();

        [Fact]
        public void Test1()
        {
            int[] arr = [1, 15, 7, 9, 2, 5, 10];
            int k = 3;
            int exp = 84;
            int res = alg.MaxSumAfterPartitioning(arr, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] arr = [1, 4, 1, 5, 7, 3, 6, 1, 9, 9, 3];
            int k = 4;
            int exp = 83;
            int res = alg.MaxSumAfterPartitioning(arr, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int[] arr = [1];
            int k = 1;
            int exp = 1;
            int res = alg.MaxSumAfterPartitioning(arr, k);
            Assert.Equal(exp, res);
        }
    }
}
