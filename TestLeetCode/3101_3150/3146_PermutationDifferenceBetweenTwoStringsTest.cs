using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3146_PermutationDifferenceBetweenTwoStringsTest
    {
        _3146_PermutationDifferenceBetweenTwoStringsAlg alg = new _3146_PermutationDifferenceBetweenTwoStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abc", t = "bac";
            int exp = 2;
            int res = alg.FindPermutationDifference(s, t);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcde", t = "edbac";
            int exp = 12;
            int res = alg.FindPermutationDifference(s, t);
            Assert.AreEqual(exp, res);
        }


    }
}
