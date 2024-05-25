using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2903_FindIndicesWithIndexAndValueDifferenceIUnitTest
    {
        _2903_FindIndicesWithIndexAndValueDifferenceIAlg alg = new _2903_FindIndicesWithIndexAndValueDifferenceIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [5, 1, 4, 1]; int indexDifference = 2, valueDifference = 4;
            int[] exp = [0, 3];
            int[] res = alg.FindIndices(nums, indexDifference, valueDifference);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 1]; int indexDifference = 0, valueDifference = 0;
            int[] exp = [0, 0];
            int[] res = alg.FindIndices(nums, indexDifference, valueDifference);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3]; int indexDifference = 2, valueDifference = 4;
            int[] exp = [-1, -1];
            int[] res = alg.FindIndices(nums, indexDifference, valueDifference);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
