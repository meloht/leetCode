using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1551_1600
{
    public class _1550_ThreeConsecutiveOddsTest
    {
        _1550_ThreeConsecutiveOddsAlg alg = new _1550_ThreeConsecutiveOddsAlg();

        [Fact]
        public void Test01()
        {
            int[] arr = [2, 6, 4, 1];
            bool exp = false;
            bool res = alg.ThreeConsecutiveOdds(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [1, 2, 34, 3, 4, 5, 7, 23, 12];
            bool exp = true;
            bool res = alg.ThreeConsecutiveOdds(arr);
            Assert.Equal(exp, res);
        }
    }
}
