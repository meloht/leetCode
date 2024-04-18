using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _821_ShortestDistanceToACharacterUnitTest
    {
        _821_ShortestDistanceToACharacterAlg alg = new _821_ShortestDistanceToACharacterAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "loveleetcode";
            char c = 'e';
            int[] exp = [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0];
            int[] res = alg.ShortestToChar(s, c);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aaab";
            char c = 'b';
            int[] exp = [3, 2, 1, 0];
            int[] res = alg.ShortestToChar(s, c);
            Assert.AreEqual(exp, res);
        }
    }
}
