using leetCode._3251_3300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3251_3300
{
    [TestClass]
    public class _3270_FindTheKeyOfTheNumbersTest
    {
        _3270_FindTheKeyOfTheNumbersAlg alg = new _3270_FindTheKeyOfTheNumbersAlg();


        [TestMethod]
        public void TestCase01()
        {
            int num1 = 1, num2 = 10, num3 = 1000;
            int exp = 0;
            int res = alg.GenerateKey(num1, num2, num3);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num1 = 987, num2 = 879, num3 = 798;
            int exp = 777;
            int res = alg.GenerateKey(num1, num2, num3);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int num1 = 1, num2 = 2, num3 = 3;
            int exp = 1;
            int res = alg.GenerateKey(num1, num2, num3);
            Assert.AreEqual(exp, res);
        }
    }
}
