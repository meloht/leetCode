using leetCode._0801_0850;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _845_LongestMountainInArrayTest
    {
        _845_LongestMountainInArrayAlg alg = new _845_LongestMountainInArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 1, 4, 7, 3, 2, 5];
            int exp = 5;
            int res = alg.LongestMountain(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [2, 2, 2];
            int exp = 0;
            int res = alg.LongestMountain(arr);
            Assert.AreEqual(exp, res);
        }

    }
}
