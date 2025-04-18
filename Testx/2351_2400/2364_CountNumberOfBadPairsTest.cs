using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2351_2400
{
    public class _2364_CountNumberOfBadPairsTest
    {
        _2364_CountNumberOfBadPairsAlg alg = new _2364_CountNumberOfBadPairsAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [4, 1, 3, 3];
            long exp = 5;
            long res = alg.CountBadPairs(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            long exp = 0;
            long res = alg.CountBadPairs(nums);
            Assert.Equal(exp, res);
        }
    }
}
