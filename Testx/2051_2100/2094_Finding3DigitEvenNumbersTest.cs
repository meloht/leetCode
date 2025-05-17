using leetCode._2051_2100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2051_2100
{
    public class _2094_Finding3DigitEvenNumbersTest
    {
        _2094_Finding3DigitEvenNumbersAlg alg = new _2094_Finding3DigitEvenNumbersAlg();

        [Fact]
        public void Test01()
        {
            int[] digits = [2, 1, 3, 0];
            int[] exp = [102, 120, 130, 132, 210, 230, 302, 310, 312, 320];
            int[] res = alg.FindEvenNumbers(digits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] digits = [2, 2, 8, 8, 2];
            int[] exp = [222, 228, 282, 288, 822, 828, 882];
            int[] res = alg.FindEvenNumbers(digits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] digits = [3, 7, 5];
            int[] exp = [];
            int[] res = alg.FindEvenNumbers(digits);
            Assert.Equal(exp, res);
        }
    }
}
