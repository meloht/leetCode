using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersTest
    {
        _1239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersAlg alg = new _1239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] arr = ["un", "iq", "ue"];
            int exp = 4;
            int res = alg.MaxLength(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] arr = ["cha", "r", "act", "ers"];
            int exp = 6;
            int res = alg.MaxLength(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] arr = ["abcdefghijklmnopqrstuvwxyz"];
            int exp = 26;
            int res = alg.MaxLength(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
