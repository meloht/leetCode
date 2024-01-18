using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0201_0250
{
    [TestClass]
    public class _233_NumberOfDigitOneUnitTest
    {
        _233_NumberOfDigitOneAlg alg = new _233_NumberOfDigitOneAlg();

        [TestMethod]
        public void TestCase01()
        {
            int exp = 6;
            int res = alg.CountDigitOne(13);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int exp = 0;
            int res = alg.CountDigitOne(0);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int exp = 12;
            int res = alg.CountDigitOne(20);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int exp = 767944060;
            int res = alg.CountDigitOne(824883294);
            Assert.AreEqual(exp, res);
        }
    }
}
