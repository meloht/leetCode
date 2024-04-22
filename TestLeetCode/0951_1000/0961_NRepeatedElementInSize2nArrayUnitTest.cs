using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0961_NRepeatedElementInSize2nArrayUnitTest
    {
        _0961_NRepeatedElementInSize2nArrayAlg alg = new _0961_NRepeatedElementInSize2nArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 3];
            int exp = 3;
            int res = alg.RepeatedNTimes(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 1, 2, 5, 3, 2];
            int exp = 2;
            int res = alg.RepeatedNTimes(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [5, 1, 5, 2, 5, 3, 5, 4];
            int exp = 5;
            int res = alg.RepeatedNTimes(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
