using leetCode.WeeklyContest._0378;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode.WeeklyContest._0378
{
    [TestClass]
    public class Alg_378_01_UnitTest
    {
        Alg_378_01 alg = new Alg_378_01();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5];
            var res = alg.HasTrailingZeros(nums);
            Assert.AreEqual(true, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 8, 16];
            var res = alg.HasTrailingZeros(nums);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 5, 7, 9];
            var res = alg.HasTrailingZeros(nums);
            Assert.AreEqual(false, res);
        }
    }
}
