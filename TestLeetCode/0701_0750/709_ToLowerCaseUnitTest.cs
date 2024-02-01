using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0701_0750
{
    [TestClass]
    public class _709_ToLowerCaseUnitTest
    {
        _709_ToLowerCaseAlg alg = new _709_ToLowerCaseAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "Hello";
            string exp = "hello";
            string res = alg.ToLowerCase(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "here";
            string exp = "here";
            string res = alg.ToLowerCase(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "LOVELY";
            string exp = "lovely";
            string res = alg.ToLowerCase(s);
            Assert.AreEqual(exp, res);
        }
    }
}
