using leetCode._1851_1900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1851_1900
{
    public class _1863_SumOfAllSubsetXorTotalsTest
    {
        _1863_SumOfAllSubsetXorTotalsAlg alg = new _1863_SumOfAllSubsetXorTotalsAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [1, 3];
            int exp = 6;
            int res = alg.SubsetXORSum(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [5, 1, 6];
            int exp = 28;
            int res = alg.SubsetXORSum(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [3, 4, 5, 6, 7, 8];
            int exp = 480;
            int res = alg.SubsetXORSum(nums);
            Assert.Equal(exp, res);
        }
    }
}
