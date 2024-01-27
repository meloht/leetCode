using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0301_0350
{
    [TestClass]
    public class _347_TopKFrequentElementsUnitTest
    {
        _347_TopKFrequentElementsAlg alg = new _347_TopKFrequentElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 1, 2, 2, 3];
            int k = 2;
            int[] exp = [1, 2];
            int[] res = alg.TopKFrequent(nums, k);

            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1];
            int k = 1;
            int[] exp = [1];
            int[] res = alg.TopKFrequent(nums, k);

            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
