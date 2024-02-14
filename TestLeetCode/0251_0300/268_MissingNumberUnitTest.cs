using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _268_MissingNumberUnitTest
    {
        _268_MissingNumberAlg alg = new _268_MissingNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 0, 1];
            int exp = 2;
            int res = alg.MissingNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 1];
            int exp = 2;
            int res = alg.MissingNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            int exp = 8;
            int res = alg.MissingNumber(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [0];
            int exp = 1;
            int res = alg.MissingNumber(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
