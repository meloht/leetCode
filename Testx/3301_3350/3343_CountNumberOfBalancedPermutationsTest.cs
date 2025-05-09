using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3301_3350
{
    public class _3343_CountNumberOfBalancedPermutationsTest
    {
        _3343_CountNumberOfBalancedPermutationsAlg alg = new _3343_CountNumberOfBalancedPermutationsAlg();

        [Fact]
        public void Test01()
        {
            string num = "123";
            int exp = 2;
            int res = alg.CountBalancedPermutations(num);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string num = "112";
            int exp = 1;
            int res = alg.CountBalancedPermutations(num);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string num = "12345";
            int exp = 0;
            int res = alg.CountBalancedPermutations(num);
            Assert.Equal(exp, res);
        }
    }
}
