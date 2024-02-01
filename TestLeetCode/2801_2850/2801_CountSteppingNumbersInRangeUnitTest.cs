using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2801_CountSteppingNumbersInRangeUnitTest
    {
        _2801_CountSteppingNumbersInRangeAlg alg = new _2801_CountSteppingNumbersInRangeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string low = "1", high = "11";
            int exp = 10;
            int res = alg.CountSteppingNumbers(low, high);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string low = "90", high = "101";
            int exp = 2;
            int res = alg.CountSteppingNumbers(low, high);
            Assert.AreEqual(exp, res);
        }
    }
}
