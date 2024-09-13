using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2398_MaximumNumberOfRobotsWithinBudgeTest
    {
        _2398_MaximumNumberOfRobotsWithinBudgeAlg alg = new _2398_MaximumNumberOfRobotsWithinBudgeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] chargeTimes = [3, 6, 1, 3, 4];
            int[] runningCosts = [2, 1, 3, 4, 5];
            int budget = 25;
            int exp = 3;
            int res = alg.MaximumRobots(chargeTimes, runningCosts, budget);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] chargeTimes = [11, 12, 19];
            int[] runningCosts = [10, 8, 7];
            int budget = 19;
            int exp = 0;
            int res = alg.MaximumRobots(chargeTimes, runningCosts, budget);
            Assert.AreEqual(exp, res);
        }
    }
}
