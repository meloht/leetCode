using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1202_SmallestStringWithSwapsUnitTest
    {
        _1202_SmallestStringWithSwapsAlg alg = new _1202_SmallestStringWithSwapsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "dcab";
            int[][] pairs = [[0, 3], [1, 2]];
            string exp = "bacd";
            string res = alg.SmallestStringWithSwaps(s, pairs);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string s = "dcab";
            int[][] pairs = [[0, 3], [1, 2], [0, 2]];
            string exp = "abcd";
            string res = alg.SmallestStringWithSwaps(s, pairs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "cba";
            int[][] pairs = [[0, 1], [1, 2]];
            string exp = "abc";
            string res = alg.SmallestStringWithSwaps(s, pairs);
            Assert.AreEqual(exp, res);
        }
    }
}
