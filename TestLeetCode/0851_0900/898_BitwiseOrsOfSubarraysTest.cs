using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _898_BitwiseOrsOfSubarraysTest
    {
        _898_BitwiseOrsOfSubarraysAlg alg = new _898_BitwiseOrsOfSubarraysAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [0];
            int exp = 1;
            int res = alg.SubarrayBitwiseORs(arr);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 1, 2];
            int exp = 3;
            int res = alg.SubarrayBitwiseORs(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [1, 2, 4];
            int exp = 6;
            int res = alg.SubarrayBitwiseORs(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
