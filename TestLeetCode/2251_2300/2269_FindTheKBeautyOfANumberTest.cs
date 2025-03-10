using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2269_FindTheKBeautyOfANumberTest
    {
        _2269_FindTheKBeautyOfANumberAlg alg = new _2269_FindTheKBeautyOfANumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 240, k = 2;
            int exp = 2;
            int res = alg.DivisorSubstrings(num, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 430043, k = 2;
            int exp = 2;
            int res = alg.DivisorSubstrings(num, k);
            Assert.AreEqual(exp, res);
        }
    }
}
