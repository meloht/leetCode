using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _853_CarFleetTest
    {
        _853_CarFleetAlg alg = new _853_CarFleetAlg();

        [Fact]
        public void Test01()
        {
            int target = 12;
            int[] position = [10, 8, 0, 5, 3];
            int[] speed = [2, 4, 1, 1, 3];
            int exp = 3;
            int res = alg.CarFleet(target, position, speed);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int target = 10;
            int[] position = [3], speed = [3];
            int exp = 1;
            int res = alg.CarFleet(target, position, speed);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int target = 100;
            int[] position = [0, 2, 4], speed = [4, 2, 1];
            int exp = 1;
            int res = alg.CarFleet(target, position, speed);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int target = 10;
            int[] position = [6, 8], speed = [3, 2];
            int exp = 2;
            int res = alg.CarFleet(target, position, speed);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            int target = 10;
            int[] position = [0, 4, 2], speed = [2, 1, 3];
            int exp = 1;
            int res = alg.CarFleet(target, position, speed);
            Assert.Equal(exp, res);
        }
    }
}
