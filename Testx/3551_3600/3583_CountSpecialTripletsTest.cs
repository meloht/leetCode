using leetCode._3551_3600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3551_3600
{
    public class _3583_CountSpecialTripletsTest
    {
        _3583_CountSpecialTripletsAlg alg = new _3583_CountSpecialTripletsAlg();

        [Fact]
        public void Test1()
        {
            int[] nums = [6, 3, 6];
            int exp = 1;
            int res = alg.SpecialTriplets(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [0, 1, 0, 0];
            int exp = 1;
            int res = alg.SpecialTriplets(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [8, 4, 2, 8, 4];
            int exp = 2;
            int res = alg.SpecialTriplets(nums);
            Assert.Equal(exp, res);
        }
    }
}
