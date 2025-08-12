using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2751_2800
{
    public class _2787_WaysToExpressAnIntegerAsSumOfPowersTest
    {
        _2787_WaysToExpressAnIntegerAsSumOfPowersAlg alg = new _2787_WaysToExpressAnIntegerAsSumOfPowersAlg();

        [Fact]
        public void Test1()
        {
            int n = 10, x = 2;
            int exp = 1;
            int res = alg.NumberOfWays(n, x);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int n = 4, x = 1;
            int exp = 2;
            int res = alg.NumberOfWays(n, x);
            Assert.Equal(exp, res);
        }
    }
}
