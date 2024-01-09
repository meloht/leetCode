using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2701_2750
{
    [TestClass]
    public class _2707_ExtraCharactersInAStringUnitTest
    {
        _2707_ExtraCharactersInAStringAlg alg = new _2707_ExtraCharactersInAStringAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            string s = "leetscode";
            string[] dictionary = ["leet", "code", "leetcode"];
            int res = alg.MinExtraChar(s, dictionary);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "sayhelloworld";
            string[] dictionary = ["hello", "world"];
            int res = alg.MinExtraChar(s, dictionary);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "voctvochpgutoywpnafylzelqsnzsbandjcqdciyoefi";
            string[] dictionary = ["tf", "v", "wadrya", "a", "cqdci", "uqfg", "voc", "zelqsn", "band", "b", "yoefi", "utoywp", "herqqn", "umra", "frfuyj", "vczatj", "sdww"];
            int res = alg.MinExtraChar(s, dictionary);
            Assert.AreEqual(11, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "smsvy";
            string[] dictionary = ["j", "p", "y", "r", "t", "nj", "k", "xj", "vg",
                "da", "m", "u", "yq", "as", "wh", "b", 
                "vo", "h", "wb", "z", "np", "uy", "i", "f", "w", "wg", "s",
                "ls", "xf", "ou", "mj", "pf"];
            int res = alg.MinExtraChar(s, dictionary);
            Assert.AreEqual(1, res);
        }
    }
}
