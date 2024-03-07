using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _387_FirstUniqueCharacterInAStringUnitTest
    {
        _387_FirstUniqueCharacterInAStringAlg alg = new _387_FirstUniqueCharacterInAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "leetcode";
            int exp = 0;
            int res=alg.FirstUniqChar(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "loveleetcode";
            int exp = 2;
            int res = alg.FirstUniqChar(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aabb";
            int exp = -1;
            int res = alg.FirstUniqChar(s);
            Assert.AreEqual(exp, res);
        }
    }
}
