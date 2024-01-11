using leetCode._2601_2650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2601_2650
{
    [TestClass]
    public class _2645_MinimumAdditionsToMakeValidStringUnitTest
    {
        _2645_MinimumAdditionsToMakeValidStringAlg alg = new _2645_MinimumAdditionsToMakeValidStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "b";
            int exp = 2;
            int res = alg.AddMinimum(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "aaa";
            int exp = 6;
            int res = alg.AddMinimum(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word = "abc";
            int exp = 0;
            int res = alg.AddMinimum(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string word = "abcaaaaa";
            int exp = 10;
            int res = alg.AddMinimum(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string word = "aaaabb";
            int exp = 9;
            int res = alg.AddMinimum(word);
            Assert.AreEqual(exp, res);
        }

    }
}
