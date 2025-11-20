using leetCode._1151_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1151_1200
{
    [TestClass]
    public class _1177_CanMakePalindromeFromSubstringTest
    {
        _1177_CanMakePalindromeFromSubstringAlg alg = new _1177_CanMakePalindromeFromSubstringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcda";
            int[][] queries = [[3, 3, 0], [1, 2, 0], [0, 3, 1], [0, 3, 2], [0, 4, 1]];
            bool[] exp = [true, false, false, true, true];
            bool[] res = alg.CanMakePaliQueries(s, queries).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

       
    }
}
