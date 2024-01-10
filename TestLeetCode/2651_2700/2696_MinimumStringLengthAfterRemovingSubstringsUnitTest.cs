using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2651_2700
{
    [TestClass]
    public class _2696_MinimumStringLengthAfterRemovingSubstringsUnitTest
    {
        _2696_MinimumStringLengthAfterRemovingSubstringsAlg alg = new _2696_MinimumStringLengthAfterRemovingSubstringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "ABFCACDB";
            int exp = 2;
            int res = alg.MinLength(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string s = "ACBBD";
            int exp = 5;
            int res = alg.MinLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "CCCCDDDD";
            int exp = 0;
            int res = alg.MinLength(s);
            Assert.AreEqual(exp, res);
        }
    }
}
