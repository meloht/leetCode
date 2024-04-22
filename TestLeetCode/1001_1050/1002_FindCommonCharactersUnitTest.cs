using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1002_FindCommonCharactersUnitTest
    {
        _1002_FindCommonCharactersAlg alg = new _1002_FindCommonCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["bella", "label", "roller"];
            string[] exp = ["e", "l", "l"];
            string[] res = alg.CommonChars(words).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["cool", "lock", "cook"];
            string[] exp = ["c", "o"];
            string[] res = alg.CommonChars(words).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

    }
}
