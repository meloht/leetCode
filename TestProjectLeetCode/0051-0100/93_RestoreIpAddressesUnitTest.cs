using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _93_RestoreIpAddressesUnitTest
    {
        _93_RestoreIpAddressesAlg alg = new _93_RestoreIpAddressesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "25525511135";
            string[] exp = { "255.255.11.135", "255.255.111.35" };
            var res = alg.RestoreIpAddresses(s);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            string s = "0000";
            string[] exp = { "0.0.0.0" };
            var res = alg.RestoreIpAddresses(s);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "101023";
            string[] exp = { "1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3" };
            var res = alg.RestoreIpAddresses(s);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
