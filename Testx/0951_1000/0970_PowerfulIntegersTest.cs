using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0970_PowerfulIntegersTest
    {
        _0970_PowerfulIntegersAlg alg = new _0970_PowerfulIntegersAlg();

        [Fact]
        public void Test01()
        {
            int x = 2, y = 3, bound = 10;
            int[] exp = [2, 3, 4, 5, 7, 9, 10];
            int[] res = alg.PowerfulIntegers(x, y, bound).ToArray();
            Assert.True(Utils.IsSameArr(exp, res));
        }

        [Fact]
        public void Test02()
        {
            int x = 3, y = 5, bound = 15;
            int[] exp = [2, 4, 6, 8, 10, 14];
            int[] res = alg.PowerfulIntegers(x, y, bound).ToArray();
            Assert.True(Utils.IsSameArr(exp,res));
        }
    }
}
