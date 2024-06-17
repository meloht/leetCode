using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _421_MaximumXorOfTwoNumbersInAnArrayTest
    {
        _421_MaximumXorOfTwoNumbersInAnArrayAlg alg = new _421_MaximumXorOfTwoNumbersInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 10, 5, 25, 2, 8];
            int exp = 28;
            int res = alg.FindMaximumXOR(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [14, 70, 53, 83, 49, 91, 36, 80, 92, 51, 66, 70];
            int exp = 127;
            int res = alg.FindMaximumXOR(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
