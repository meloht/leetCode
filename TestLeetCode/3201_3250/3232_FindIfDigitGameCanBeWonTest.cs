using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3232_FindIfDigitGameCanBeWonTest
    {
        _3232_FindIfDigitGameCanBeWonAlg alg = new _3232_FindIfDigitGameCanBeWonAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 10];
            bool exp = false;
            bool res = alg.CanAliceWin(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5, 14];
            bool exp = true;
            bool res = alg.CanAliceWin(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [5, 5, 5, 25];
            bool exp = true;
            bool res = alg.CanAliceWin(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
