using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3442_MaximumDifferenceBetweenEvenAndOddFrequencyITest
    {
        _3442_MaximumDifferenceBetweenEvenAndOddFrequencyIAlg alg = new _3442_MaximumDifferenceBetweenEvenAndOddFrequencyIAlg();

        [Fact]
        public void Test01()
        {
            string s = "aaaaabbc";
            int exp = 3;
            int res = alg.MaxDifference(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "abcabcab";
            int exp = 1;
            int res = alg.MaxDifference(s);
            Assert.Equal(exp, res);
        }
    }
}
