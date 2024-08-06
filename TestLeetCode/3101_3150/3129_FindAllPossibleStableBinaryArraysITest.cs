using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3129_FindAllPossibleStableBinaryArraysITest
    {
        _3129_FindAllPossibleStableBinaryArraysIAlg alg = new _3129_FindAllPossibleStableBinaryArraysIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int zero = 1, one = 1, limit = 2;
            int exp = 2;
            int res = alg.NumberOfStableArrays(zero, one, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int zero = 1, one = 2, limit = 1;
            int exp = 1;
            int res = alg.NumberOfStableArrays(zero, one, limit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int zero = 3, one = 3, limit = 2;
            int exp = 14;
            int res = alg.NumberOfStableArrays(zero, one, limit);
            Assert.AreEqual(exp, res);
        }
    }
}
