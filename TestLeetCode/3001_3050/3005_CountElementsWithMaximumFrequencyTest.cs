using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3005_CountElementsWithMaximumFrequencyTest
    {
        _3005_CountElementsWithMaximumFrequencyAlg alg = new _3005_CountElementsWithMaximumFrequencyAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [1, 2, 2, 3, 1, 4];
            int exp = 4;
            int res = alg.MaxFrequencyElements(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            int exp = 5;
            int res = alg.MaxFrequencyElements(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
