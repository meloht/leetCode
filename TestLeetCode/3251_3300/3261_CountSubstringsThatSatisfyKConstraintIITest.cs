using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3261_CountSubstringsThatSatisfyKConstraintIITest
    {
        _3261_CountSubstringsThatSatisfyKConstraintIIAlg alg = new _3261_CountSubstringsThatSatisfyKConstraintIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "0001111";
            int k = 2;
            int[][] queries = [[0, 6]];
            long[] exp = [26];
            long[] res = alg.CountKConstraintSubstrings(s, k, queries);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);


        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "010101";
            int k = 1;
            int[][] queries = [[0, 5], [1, 4], [2, 3]];
            long[] exp = [15, 9, 3];
            long[] res = alg.CountKConstraintSubstrings(s, k, queries);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);


        }
    }
}
