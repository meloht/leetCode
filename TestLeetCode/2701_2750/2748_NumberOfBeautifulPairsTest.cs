using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2748_NumberOfBeautifulPairsTest
    {
        _2748_NumberOfBeautifulPairsAlg alg = new _2748_NumberOfBeautifulPairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 5, 1, 4];
            int exp = 5;
            int res = alg.CountBeautifulPairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [11, 21, 12];
            int exp = 2;
            int res = alg.CountBeautifulPairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [756, 1324, 2419, 495, 106, 111, 1649, 1474, 2001, 1633, 273, 1804, 2102, 1782, 705, 1529, 1761, 1613, 111, 186, 412];
            int exp = 183;
            int res = alg.CountBeautifulPairs(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
