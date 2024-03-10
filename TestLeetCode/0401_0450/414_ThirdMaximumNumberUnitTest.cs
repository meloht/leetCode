using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _414_ThirdMaximumNumberUnitTest
    {
        _414_ThirdMaximumNumberAlg alg = new _414_ThirdMaximumNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 1];
            int exp = 1;
            int res = alg.ThirdMax(nums);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2];
            int exp = 2;
            int res = alg.ThirdMax(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 2, 3, 1];
            int exp = 1;
            int res = alg.ThirdMax(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [2, 2, 3, 2];
            int exp = 3;
            int res = alg.ThirdMax(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
