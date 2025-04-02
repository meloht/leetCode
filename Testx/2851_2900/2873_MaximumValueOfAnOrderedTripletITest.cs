using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2851_2900
{
    public class _2873_MaximumValueOfAnOrderedTripletITest
    {
        _2873_MaximumValueOfAnOrderedTripletIAlg alg = new _2873_MaximumValueOfAnOrderedTripletIAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [12, 6, 1, 2, 7];
            long exp = 77;
            long res = alg.MaximumTripletValue(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [1, 10, 3, 4, 19];
            long exp = 133;
            long res = alg.MaximumTripletValue(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] nums = [1, 2, 3];
            long exp = 0;
            long res = alg.MaximumTripletValue(nums);
            Assert.Equal(exp, res);
        }
    }
}
