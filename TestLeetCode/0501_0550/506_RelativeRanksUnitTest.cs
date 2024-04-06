using leetCode._0501_0550;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _506_RelativeRanksUnitTest
    {
        _506_RelativeRanksAlg alg = new _506_RelativeRanksAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] score = [5, 4, 3, 2, 1];
            string[] exp = ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"];
            string[] res = alg.FindRelativeRanks(score);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] score = [10, 3, 8, 9, 4];
            string[] exp = ["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"];
            string[] res = alg.FindRelativeRanks(score);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

    }
}
