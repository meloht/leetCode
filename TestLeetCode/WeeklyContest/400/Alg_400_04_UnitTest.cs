using leetCode.WeeklyContest._400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WeeklyContest._400
{
    [TestClass]
    public class Alg_400_04_UnitTest
    {
        Alg_400_04 alg = new Alg_400_04();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 4, 5];
            int k = 3;
            int exp = 1;
            int res = alg.MinimumDifference(nums, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 1, 2];
            int k = 2;
            int exp = 0;
            int res = alg.MinimumDifference(nums, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1];
            int k = 10;
            int exp = 9;
            int res = alg.MinimumDifference(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
