using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2109_AddingSpacesToAStringTest
    {
        _2109_AddingSpacesToAStringAlg alg = new _2109_AddingSpacesToAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "LeetcodeHelpsMeLearn";
            int[] spaces = [8, 13, 15];
            string exp = "Leetcode Helps Me Learn";
            string res = alg.AddSpaces(s, spaces);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "icodeinpython";
            int[] spaces = [1, 5, 7, 9];
            string exp = "i code in py thon";
            string res = alg.AddSpaces(s, spaces);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            string s = "spacing";
            int[] spaces = [0, 1, 2, 3, 4, 5, 6];
            string exp = " s p a c i n g";
            string res = alg.AddSpaces(s, spaces);
            Assert.AreEqual(exp, res);
        }
    }
}
