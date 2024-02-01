using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _326_PowerOfThreeUnitTest
    {
        _326_PowerOfThreeAlg alg = new _326_PowerOfThreeAlg();
        [TestMethod]
        public void TestCase01()
        {
            bool exp = true;
            bool res = alg.IsPowerOfThree(27);
            Assert.AreEqual(exp,res);
        }

        [TestMethod]
        public void TestCase02()
        {
            bool exp = false;
            bool res = alg.IsPowerOfThree(0);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            bool exp = true;
            bool res = alg.IsPowerOfThree(9);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            bool exp = false;
            bool res = alg.IsPowerOfThree(45);
            Assert.AreEqual(exp, res);
        }
    }
}
