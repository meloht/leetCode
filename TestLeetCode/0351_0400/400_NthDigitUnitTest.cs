using leetCode._0351_0400;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _400_NthDigitUnitTest
    {
        _400_NthDigitAlg alg = new _400_NthDigitAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int exp = 3;
            int res = alg.FindNthDigit(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 11;
            int exp = 0;
            int res = alg.FindNthDigit(n);
            Assert.AreEqual(exp, res);
        }
    }
}
