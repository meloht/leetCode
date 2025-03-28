using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2716_MinimizeStringLengthTest
    {
        _2716_MinimizeStringLengthAlg alg = new _2716_MinimizeStringLengthAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aaabc";
            int exp = 3;
            int res = alg.MinimizedStringLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cbbd";
            int exp = 3;
            int res = alg.MinimizedStringLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "dddaaa";
            int exp = 3;
            int res = alg.MinimizedStringLength(s);
            Assert.AreEqual(exp, res);
        }
    }
}
