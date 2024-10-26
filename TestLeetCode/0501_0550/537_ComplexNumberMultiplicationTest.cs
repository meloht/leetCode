using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _537_ComplexNumberMultiplicationTest
    {
        _537_ComplexNumberMultiplicationAlg alg = new _537_ComplexNumberMultiplicationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num1 = "1+1i", num2 = "1+1i";
            string exp = "0+2i";
            string res=alg.ComplexNumberMultiply(num1, num2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num1 = "1+-1i", num2 = "1+-1i";
            string exp = "0+-2i";
            string res = alg.ComplexNumberMultiply(num1, num2);
            Assert.AreEqual(exp, res);
        }
    }
}
