using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _950_RevealCardsInIncreasingOrderTest
    {
        _950_RevealCardsInIncreasingOrderAlg alg = new _950_RevealCardsInIncreasingOrderAlg();

        [Fact]
        public void Test01()
        {
            int[] nums = [17, 13, 11, 2, 3, 5, 7];
            int[] exp = [2, 13, 3, 11, 5, 17, 7];
            int[] res = alg.DeckRevealedIncreasing(nums);
            Assert.True(exp.SequenceEqual(res));
        }

       
    }
}
