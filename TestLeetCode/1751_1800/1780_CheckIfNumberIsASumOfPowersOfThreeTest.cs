using leetCode._1751_1800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1751_1800
{
    [TestClass]
    public class _1780_CheckIfNumberIsASumOfPowersOfThreeTest
    {
        _1780_CheckIfNumberIsASumOfPowersOfThreeAlg alg = new _1780_CheckIfNumberIsASumOfPowersOfThreeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 12;
            bool exp = true;
            bool res = alg.CheckPowersOfThree(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 91;
            bool exp = true;
            bool res = alg.CheckPowersOfThree(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 21;
            bool exp = false;
            bool res = alg.CheckPowersOfThree(n);
            Assert.AreEqual(exp, res);
        }
    }
}
