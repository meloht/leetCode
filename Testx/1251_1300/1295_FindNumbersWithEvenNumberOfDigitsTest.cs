using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1251_1300
{
    public class _1295_FindNumbersWithEvenNumberOfDigitsTest
    {
        _1295_FindNumbersWithEvenNumberOfDigitsAlg alg = new _1295_FindNumbersWithEvenNumberOfDigitsAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [12, 345, 2, 6, 7896];
            int exp = 2;
            int res = alg.FindNumbers(nums);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] nums = [555, 901, 482, 1771];
            int exp = 1;
            int res = alg.FindNumbers(nums);
            Assert.Equal(exp, res);
        }
    }
}
