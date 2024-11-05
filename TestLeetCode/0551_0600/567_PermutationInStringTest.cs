using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _567_PermutationInStringTest
    {
        _567_PermutationInStringAlg alg = new _567_PermutationInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "ab", s2 = "eidbaooo";
            bool exp = true;
            bool res=alg.CheckInclusion(s1, s2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "ab", s2 = "eidboaoo";
            bool exp = false;
            bool res = alg.CheckInclusion(s1, s2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "adc", s2 = "dcda";
            bool exp = true;
            bool res = alg.CheckInclusion(s1, s2);
            Assert.AreEqual(exp, res);
        }
    }
}
