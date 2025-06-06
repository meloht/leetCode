using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1011_CapacityToShipPackagesWithinDDaysTest
    {
        _1011_CapacityToShipPackagesWithinDDaysAlg alg = new _1011_CapacityToShipPackagesWithinDDaysAlg();

        [Fact]
        public void Test01()
        {
            int[] weights = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int days = 5;
            int exp = 15;
            int res = alg.ShipWithinDays(weights, days);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] weights = [3, 2, 2, 4, 1, 4];
            int days = 3;
            int exp = 6;
            int res = alg.ShipWithinDays(weights, days);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] weights = [1, 2, 3, 1, 1];
            int days = 4;
            int exp = 3;
            int res = alg.ShipWithinDays(weights, days);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] weights = [70, 259, 379, 369, 287, 145, 259, 29, 150, 410, 493, 121, 184, 92, 79, 168, 269, 209, 139, 437];
            int days = 20;
            int exp = 493;
            int res = alg.ShipWithinDays(weights, days);
            Assert.Equal(exp, res);
        }
    }
}
