using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3158_FindTheXorOfNumbersWhichAppearTwiceTest
    {
        _3158_FindTheXorOfNumbersWhichAppearTwiceAlg alg = new _3158_FindTheXorOfNumbersWhichAppearTwiceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 1, 3];
            int exp = 1;
            int res = alg.DuplicateNumbersXOR(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3];
            int exp = 0;
            int res = alg.DuplicateNumbersXOR(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 2, 1];
            int exp = 3;
            int res = alg.DuplicateNumbersXOR(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
