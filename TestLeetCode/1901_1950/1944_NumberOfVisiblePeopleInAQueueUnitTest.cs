using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1901_1950
{
    [TestClass]
    public class _1944_NumberOfVisiblePeopleInAQueueUnitTest
    {
        _1944_NumberOfVisiblePeopleInAQueueAlg alg = new _1944_NumberOfVisiblePeopleInAQueueAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] heights = [10, 6, 8, 5, 11, 9];
            int[] exp = [3, 1, 2, 1, 1, 0];

            var res = alg.CanSeePersonsCount(heights);
            Assert.AreEqual(true, exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] heights = [5, 1, 2, 3, 10];
            int[] exp = [4, 1, 1, 1, 0];

            var res = alg.CanSeePersonsCount(heights);
            Assert.AreEqual(true, exp.SequenceEqual(res));

        }
    }
}
