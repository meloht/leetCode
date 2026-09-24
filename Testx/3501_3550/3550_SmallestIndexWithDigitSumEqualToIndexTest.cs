using leetCode._3501_3550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3501_3550
{
    public class _3550_SmallestIndexWithDigitSumEqualToIndexTest
    {
        _3550_SmallestIndexWithDigitSumEqualToIndexAlg alg = new _3550_SmallestIndexWithDigitSumEqualToIndexAlg();

        [Fact]
        public void Test1()
        {
            int[] nums = [1, 3, 2];
            int exp = 2;
            int res = alg.SmallestIndex(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [1, 10, 11];
            int exp = 1;
            int res = alg.SmallestIndex(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [1, 2, 3];
            int exp = -1;
            int res = alg.SmallestIndex(nums);
            Assert.Equal(exp, res);
        }

    }
}
