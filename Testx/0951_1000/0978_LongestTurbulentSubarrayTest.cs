using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0978_LongestTurbulentSubarrayTest
    {
        _0978_LongestTurbulentSubarrayAlg alg = new _0978_LongestTurbulentSubarrayAlg();

        [Fact]
        public void Test01()
        {
            int[] arr = [9, 4, 2, 10, 7, 8, 8, 1, 9];
            int exp = 5;
            int res = alg.MaxTurbulenceSize(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [4, 8, 12, 16];
            int exp = 2;
            int res = alg.MaxTurbulenceSize(arr);
            Assert.Equal(exp, res);
        }
    }
}
