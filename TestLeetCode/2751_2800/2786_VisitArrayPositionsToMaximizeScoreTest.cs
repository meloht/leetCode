using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2786_VisitArrayPositionsToMaximizeScoreTest
    {
        _2786_VisitArrayPositionsToMaximizeScoreAlg alg = new _2786_VisitArrayPositionsToMaximizeScoreAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, 6, 1, 9, 2];
            int x = 5;
            long exp = 13;
            long res = alg.MaxScore(nums, x);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 6, 8];
            int x = 3;
            long exp = 20;
            long res = alg.MaxScore(nums, x);
            Assert.AreEqual(exp, res);
        }
    }
}
