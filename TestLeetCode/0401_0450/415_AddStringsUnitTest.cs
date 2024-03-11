using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _415_AddStringsUnitTest
    {
        _415_AddStringsAlg alg = new _415_AddStringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num1 = "11", num2 = "123";
            string exp = "134";
            string res = alg.AddStrings(num1, num2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num1 = "456", num2 = "77";
            string exp = "533";
            string res = alg.AddStrings(num1, num2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string num1 = "0", num2 = "0";
            string exp = "0";
            string res = alg.AddStrings(num1, num2);
            Assert.AreEqual(exp, res);
        }
    }
}
