using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _468_ValidateIpAddressTest
    {
        _468_ValidateIpAddressAlg alg = new _468_ValidateIpAddressAlg();

        [TestMethod]
        public void TestCase01()
        {
            string queryIP = "172.16.254.1";
            string exp = "IPv4";
            string res = alg.ValidIPAddress(queryIP);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string queryIP = "2001:0db8:85a3:0:0:8A2E:0370:7334";
            string exp = "IPv6";
            string res = alg.ValidIPAddress(queryIP);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string queryIP = "256.256.256.256";
            string exp = "Neither";
            string res = alg.ValidIPAddress(queryIP);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string queryIP = "20EE:FGb8:85a3:0:0:8A2E:0370:7334";
            string exp = "Neither";
            string res = alg.ValidIPAddress(queryIP);
            Assert.AreEqual(exp, res);
        }

    }
}
