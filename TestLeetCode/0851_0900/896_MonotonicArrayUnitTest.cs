using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _896_MonotonicArrayUnitTest
    {
        _896_MonotonicArrayAlg alg = new _896_MonotonicArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 2, 3];
            bool exp = true;
            bool res = alg.IsMonotonic(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [6, 5, 4, 4];
            bool exp = true;
            bool res = alg.IsMonotonic(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 2];
            bool exp = false;
            bool res = alg.IsMonotonic(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [2, 2, 2, 1, 4, 5];
            bool exp = false;
            bool res = alg.IsMonotonic(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
