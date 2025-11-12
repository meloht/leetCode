using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2651_2700
{
    [TestClass]
    public class _2654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1Test
    {
        _2654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1Alg alg = new _2654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1Alg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 6, 3, 4];
            int exp = 4;
            int res = alg.MinOperations(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 10, 6, 14];
            int exp = -1;
            int res = alg.MinOperations(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
