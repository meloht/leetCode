using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3363_FindTheMaximumNumberOfFruitsCollectedTest
    {
        _3363_FindTheMaximumNumberOfFruitsCollectedAlg alg = new _3363_FindTheMaximumNumberOfFruitsCollectedAlg();

        [Fact]
        public void Test1()
        {
            int[][] fruits = [[1, 2, 3, 4], [5, 6, 8, 7], [9, 10, 11, 12], [13, 14, 15, 16]];
            int exp = 100;
            int res = alg.MaxCollectedFruits(fruits);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[][] fruits = [[1, 1], [1, 1]];
            int exp = 4;
            int res = alg.MaxCollectedFruits(fruits);
            Assert.Equal(exp, res);
        }
    }
}
