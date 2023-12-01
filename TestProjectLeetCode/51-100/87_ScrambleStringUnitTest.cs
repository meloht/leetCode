using leetCode;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _87_ScrambleStringUnitTest
    {
        _87_ScrambleStringAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _87_ScrambleStringAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "great", s2 = "rgeat";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "abcde", s2 = "caebd";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "a", s2 = "a";
            var res = alg.IsScramble(s1, s2);
            Assert.AreEqual(true, res);
        }
    }
}
