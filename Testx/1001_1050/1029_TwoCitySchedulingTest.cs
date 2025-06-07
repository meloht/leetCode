using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1029_TwoCitySchedulingTest
    {
        _1029_TwoCitySchedulingAlg alg = new _1029_TwoCitySchedulingAlg();

        [Fact]
        public void Test01()
        {
            int[][] costs = [[10, 20], [30, 200], [400, 50], [30, 20]];
            int exp = 110;
            int res = alg.TwoCitySchedCost(costs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] costs = [[259, 770], [448, 54], [926, 667], [184, 139], [840, 118], [577, 469]];
            int exp = 1859;
            int res = alg.TwoCitySchedCost(costs);
            Assert.Equal(exp, res);
        }
    }
}
