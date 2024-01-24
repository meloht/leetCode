using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _242_ValidAnagramUnitTest
    {
        _242_ValidAnagramAlg alg = new _242_ValidAnagramAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "anagram", t = "nagaram";
            bool exp = true;
            bool res = alg.IsAnagram(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "rat", t = "car";
            bool exp = false;
            bool res = alg.IsAnagram(s, t);
            Assert.AreEqual(exp, res);
        }
    }
}
