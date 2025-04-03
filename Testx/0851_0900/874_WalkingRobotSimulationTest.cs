using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _874_WalkingRobotSimulationTest
    {
        _874_WalkingRobotSimulationAlg alg = new _874_WalkingRobotSimulationAlg();

        [Fact]
        public void Test01()
        {
            int[] commands = [4, -1, 3];
            int[][] obstacles = [];
            int exp = 25;
            int res = alg.RobotSim(commands, obstacles);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] commands = [4, -1, 4, -2, 4];
            int[][] obstacles = [[2, 4]];
            int exp = 65;
            int res = alg.RobotSim(commands, obstacles);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] commands = [6, -1, -1, 6];
            int[][] obstacles = [[0, 0]];
            int exp = 36;
            int res = alg.RobotSim(commands, obstacles);
            Assert.Equal(exp, res);
        }
    }
}
