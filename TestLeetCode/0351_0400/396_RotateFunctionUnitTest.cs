using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _396_RotateFunctionUnitTest
    {
        _396_RotateFunctionAlg alg = new _396_RotateFunctionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 3, 2, 6];
            int exp = 26;
            int res = alg.MaxRotateFunction(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [100];
            int exp = 0;
            int res = alg.MaxRotateFunction(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
