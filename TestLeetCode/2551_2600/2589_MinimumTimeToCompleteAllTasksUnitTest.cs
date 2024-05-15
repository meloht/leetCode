using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2589_MinimumTimeToCompleteAllTasksUnitTest
    {
        _2589_MinimumTimeToCompleteAllTasksAlg alg = new _2589_MinimumTimeToCompleteAllTasksAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[][] tasks = [[2, 3, 1], [4, 5, 1], [1, 5, 2]];
            int exp = 2;
            int res = alg.FindMinimumTime(tasks);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] tasks = [[1, 3, 2], [2, 5, 3], [5, 6, 2]];
            int exp = 4;
            int res = alg.FindMinimumTime(tasks);
            Assert.AreEqual(exp, res);
        }
    }
}
