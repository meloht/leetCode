using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0251_0300
{
    [TestClass]
    public class _283_MoveZeroesUnitTest
    {
        _283_MoveZeroesAlg alg = new _283_MoveZeroesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1, 0, 3, 12];
            int[] exp = [1, 3, 12, 0, 0];
            alg.MoveZeroes(nums);
            Assert.AreEqual(true, exp.SequenceEqual(nums));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0];
            int[] exp = [0];
            alg.MoveZeroes(nums);
            Assert.AreEqual(true, exp.SequenceEqual(nums));
        }

    }
}
