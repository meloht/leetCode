using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _923_3SumWithMultiplicityTest
    {
        _923_3SumWithMultiplicityAlg alg = new _923_3SumWithMultiplicityAlg();
        [Fact]
        public void Test01()
        {
            int[] arr = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5];
            int target = 8;
            int exp = 20;
            int res = alg.ThreeSumMulti(arr, target);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [1, 1, 2, 2, 2, 2];
            int target = 5;
            int exp = 12;
            int res = alg.ThreeSumMulti(arr, target);
            Assert.Equal(exp, res);
        }
    }
}
