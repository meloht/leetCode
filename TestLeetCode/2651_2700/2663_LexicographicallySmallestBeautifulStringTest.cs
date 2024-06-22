using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2651_2700
{
    [TestClass]
    public class _2663_LexicographicallySmallestBeautifulStringTest
    {
        _2663_LexicographicallySmallestBeautifulStringAlg alg=new _2663_LexicographicallySmallestBeautifulStringAlg();

        [TestMethod]
        public void TestMethod1()
        {
            string s = "abcz";
            int k = 26;
            string exp = "abda";
            string res = alg.SmallestBeautifulString(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "dc";
            int k = 4;
            string exp = "";
            string res = alg.SmallestBeautifulString(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "ced";
            int k = 6;
            string exp = "cef";
            string res = alg.SmallestBeautifulString(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "abdc";
            int k = 4;
            string exp = "acba";
            string res = alg.SmallestBeautifulString(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string s = "dbcdb";
            int k = 4;
            string exp = "dcabc";
            string res = alg.SmallestBeautifulString(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
