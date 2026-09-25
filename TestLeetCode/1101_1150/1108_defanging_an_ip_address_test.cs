using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1101_1150
{
    [TestClass]
    public class _1108_defanging_an_ip_address_test
    {
        _1108_defanging_an_ip_address alg = new _1108_defanging_an_ip_address();

        [TestMethod]
        public void TestCase01()
        {
            string address = "1.1.1.1";
            string exp = "1[.]1[.]1[.]1";
            string res = alg.DefangIPaddr(address);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string address = "255.100.50.0";
            string exp = "255[.]100[.]50[.]0";
            string res = alg.DefangIPaddr(address);
            Assert.AreEqual(exp, res);
        }
    }
}
