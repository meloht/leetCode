using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _645_SetMismatchUnitTest
    {
        _645_SetMismatchAlg alg = new _645_SetMismatchAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 2, 4];
            int[] exp = [2, 3];
            int[] res = alg.FindErrorNums(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1];
            int[] exp = [1, 2];
            int[] res = alg.FindErrorNums(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
