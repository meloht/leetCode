using leetCode._1801_1850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1801_1850
{
    [TestClass]
    public class _1822_SignOfTheProductOfAnArrayUnitTest
    {
        _1822_SignOfTheProductOfAnArrayAlg alg = new _1822_SignOfTheProductOfAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-1, -2, -3, -4, 3, 2, 1];
            int exp = 1;
            int res = alg.ArraySign(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 5, 0, 2, -3];
            int exp = 0;
            int res = alg.ArraySign(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-1, 1, -1, 1, -1];
            int exp = -1;
            int res = alg.ArraySign(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [41, 65, 14, 80, 20, 10, 55, 58, 24, 56,
                28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83,
                78, 82, 70, 15, -41];
            int exp = -1;
            int res = alg.ArraySign(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
