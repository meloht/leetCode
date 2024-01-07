using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0351_0400
{
    [TestClass]
    public class _383_RansomNoteUnitTest
    {
        _383_RansomNoteAlg alg = new _383_RansomNoteAlg();


        [TestMethod]
        public void TestCase01()
        {
            string ransomNote = "a";
            string magazine = "b";
            bool exp = false;
            bool bl = alg.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(exp, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string ransomNote = "aa";
            string magazine = "ab";
            bool exp = false;
            bool bl = alg.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(exp, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string ransomNote = "aa";
            string magazine = "aab";
            bool exp = true;
            bool bl = alg.CanConstruct(ransomNote, magazine);
            Assert.AreEqual(exp, bl);
        }
    }
}
