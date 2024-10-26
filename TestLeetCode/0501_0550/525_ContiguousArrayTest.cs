using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _525_ContiguousArrayTest
    {
        _525_ContiguousArrayAlg alg = new _525_ContiguousArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1];
            int exp = 2;
            int res = alg.FindMaxLength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 1, 0];
            int exp = 2;
            int res = alg.FindMaxLength(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
