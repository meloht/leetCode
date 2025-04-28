using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _948_BagOfTokensTest
    {
        _948_BagOfTokensAlg alg = new _948_BagOfTokensAlg();

        [Fact]
        public void Test01()
        {
            int[] tokens = [100];
            int power = 50;
            int exp = 0;
            int res = alg.BagOfTokensScore(tokens, power);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] tokens = [200, 100];
            int power = 150;
            int exp = 1;
            int res = alg.BagOfTokensScore(tokens, power);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] tokens = [100, 200, 300, 400];
            int power = 200;
            int exp = 2;
            int res = alg.BagOfTokensScore(tokens, power);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] tokens = [71, 55, 82];
            int power = 54;
            int exp = 0;
            int res = alg.BagOfTokensScore(tokens, power);
            Assert.Equal(exp, res);
        }
    }
}
