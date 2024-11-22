using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3233_FindTheCountOfNumbersWhichAreNotSpecialTest
    {
        _3233_FindTheCountOfNumbersWhichAreNotSpecialAlg alg = new _3233_FindTheCountOfNumbersWhichAreNotSpecialAlg();

        [TestMethod]
        public void TestCase01()
        {
            int l = 5, r = 7;
            int exp = 3;
            int res = alg.NonSpecialCount(l, r);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int l = 4, r = 16;
            int exp = 11;
            int res = alg.NonSpecialCount(l, r);
            Assert.AreEqual(exp, res);
        }
    }
}
