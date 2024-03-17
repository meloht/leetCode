using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _611_ValidTriangleNumberUnitTest
    {
        _611_ValidTriangleNumberAlg alg = new _611_ValidTriangleNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 2, 3, 4];
            int exp = 3;
            int res = alg.TriangleNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 2, 3, 4];
            int exp = 4;
            int res = alg.TriangleNumber(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
