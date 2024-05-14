using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2244_MinimumRoundsToCompleteAllTasksUnitTest
    {
        _2244_MinimumRoundsToCompleteAllTasksAlg alg = new _2244_MinimumRoundsToCompleteAllTasksAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] tasks = [2, 2, 3, 3, 2, 4, 4, 4, 4, 4];
            int exp = 4;
            int res = alg.MinimumRounds(tasks);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] tasks = [2, 3, 3];
            int exp = -1;
            int res = alg.MinimumRounds(tasks);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] tasks = [5, 5, 5, 5];
            int exp = 2;
            int res = alg.MinimumRounds(tasks);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] tasks = [66, 66, 63, 61, 63, 63, 64, 66, 66, 65, 66, 65, 61, 67, 68, 66, 62, 67, 61, 64, 66, 60, 69, 66, 65, 68, 63, 60, 67, 62, 68, 60, 66, 64, 60, 60, 60, 62, 66, 64, 63, 65, 60, 69, 63, 68, 68, 69, 68, 61];
            int exp = 20;
            int res = alg.MinimumRounds(tasks);
            Assert.AreEqual(exp, res);
        }
    }
}
