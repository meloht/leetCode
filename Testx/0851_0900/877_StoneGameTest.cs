using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _877_StoneGameTest
    {
        _877_StoneGameAlg alg = new _877_StoneGameAlg();

        [Fact]
        public void Test01()
        {
            int[] piles = [5, 3, 4, 5];
            bool exp = true;
            bool res = alg.StoneGame(piles);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] piles = [5, 3, 4, 5];
            bool exp = true;
            bool res = alg.StoneGame(piles);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] piles = [7, 8, 8, 10];
            bool exp = true;
            bool res = alg.StoneGame(piles);
            Assert.Equal(exp, res);
        }
    }
}
