using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1542_FindLongestAwesomeSubstringUnitTest
    {
        _1542_FindLongestAwesomeSubstringAlg alg = new _1542_FindLongestAwesomeSubstringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "3242415";
            int exp = 5;
            int res = alg.LongestAwesome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "12345678";
            int exp = 1;
            int res = alg.LongestAwesome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "213123";
            int exp = 6;
            int res = alg.LongestAwesome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "00";
            int exp = 2;
            int res = alg.LongestAwesome(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "9498331";
            int exp = 3;
            int res = alg.LongestAwesome(s);
            Assert.AreEqual(exp, res);
        }
    }
}
