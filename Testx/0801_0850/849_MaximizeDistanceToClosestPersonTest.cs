using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0801_0850
{
    public class _849_MaximizeDistanceToClosestPersonTest
    {
        _849_MaximizeDistanceToClosestPersonAlg alg = new _849_MaximizeDistanceToClosestPersonAlg();

        [Fact]
        public void Test01()
        {
            int[] seats = [1, 0, 0, 0, 1, 0, 1];
            int exp = 2;
            int res = alg.MaxDistToClosest(seats);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] seats = [1, 0, 0, 0];
            int exp = 3;
            int res = alg.MaxDistToClosest(seats);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] seats = [0, 1];
            int exp = 1;
            int res = alg.MaxDistToClosest(seats);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] seats = [1, 0, 0, 1];
            int exp = 1;
            int res = alg.MaxDistToClosest(seats);
            Assert.Equal(exp, res);
        }
    }
}
