using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2651_2700
{
    [TestClass]
    public class _2670_FindTheDistinctDifferenceArrayUnitTest
    {
        _2670_FindTheDistinctDifferenceArrayAlg alg = new _2670_FindTheDistinctDifferenceArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int[] exp = [-3, -1, 1, 3, 5];
            var res = alg.DistinctDifferenceArray(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 2, 3, 4, 2];
            int[] exp = [-2, -1, 0, 2, 3];
            var res = alg.DistinctDifferenceArray(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
