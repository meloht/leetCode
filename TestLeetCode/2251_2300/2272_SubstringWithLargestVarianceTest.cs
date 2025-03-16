using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2272_SubstringWithLargestVarianceTest
    {
        _2272_SubstringWithLargestVarianceAlg alg = new _2272_SubstringWithLargestVarianceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aababbb";
            int exp = 3;
            int res = alg.LargestVariance(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcde";
            int exp = 0;
            int res = alg.LargestVariance(s);
            Assert.AreEqual(exp, res);
        }
    }
}
