using leetCode._3451_3500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3451_3500
{
    public class _3479_FruitsIntoBasketsIIITest
    {
        _3479_FruitsIntoBasketsIIIAlg alg = new _3479_FruitsIntoBasketsIIIAlg();

        [Fact]
        public void Test1()
        {
            int[] fruits = [4, 2, 5], baskets = [3, 5, 4];
            int exp = 1;
            int res = alg.NumOfUnplacedFruits(fruits, baskets);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] fruits = [3, 6, 1], baskets = [6, 4, 7];
            int exp = 0;
            int res = alg.NumOfUnplacedFruits(fruits, baskets);
            Assert.Equal(exp, res);
        }
    }
}
