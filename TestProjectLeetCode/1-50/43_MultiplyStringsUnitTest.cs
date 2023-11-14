using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _43_MultiplyStringsUnitTest
    {
        _43_MultiplyStringsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _43_MultiplyStringsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var num1 = "2";
            var num2 = "3";
            var res = alg.Multiply(num1,num2);
            Assert.AreEqual("6", res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var num1 = "123";
            var num2 = "456";
            var res = alg.Multiply(num1, num2);
            Assert.AreEqual("56088", res);
        }
        [TestMethod]
        public void TestCase03()
        {
            var num1 = "52";
            var num2 = "60";
            var res = alg.Multiply(num1, num2);
            Assert.AreEqual("3120", res);
        }
    }
}
