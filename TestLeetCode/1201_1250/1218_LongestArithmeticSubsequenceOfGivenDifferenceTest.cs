using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1218_LongestArithmeticSubsequenceOfGivenDifferenceTest
    {
        _1218_LongestArithmeticSubsequenceOfGivenDifferenceAlg alg = new _1218_LongestArithmeticSubsequenceOfGivenDifferenceAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 3, 4];
            int difference = 1;
            int exp = 4;
            int res = alg.LongestSubsequence(arr, difference);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 3, 5, 7];
            int difference = 1;
            int exp = 1;
            int res = alg.LongestSubsequence(arr, difference);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [1, 5, 7, 8, 5, 3, 4, 2, 1];
            int difference = -2;
            int exp = 4;
            int res = alg.LongestSubsequence(arr, difference);
            Assert.AreEqual(exp, res);
        }
    }
}
