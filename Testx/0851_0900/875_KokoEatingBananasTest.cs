using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _875_KokoEatingBananasTest
    {
        _875_KokoEatingBananasAlg alg = new _875_KokoEatingBananasAlg();
        
        [Fact]
        public void Test01()
        {
            int[] piles = [3, 6, 7, 11];
            int h = 8;
            int exp = 4;
            int res = alg.MinEatingSpeed(piles, h);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] piles = [30, 11, 23, 4, 20];
            int h = 5;
            int exp = 30;
            int res = alg.MinEatingSpeed(piles, h);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] piles = [30, 11, 23, 4, 20];
            int h = 6;
            int exp = 23;
            int res = alg.MinEatingSpeed(piles, h);
            Assert.Equal(exp, res);
        }
    }
}
