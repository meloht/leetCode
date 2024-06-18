using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _420_StrongPasswordCheckerTest
    {
        _420_StrongPasswordCheckerAlg alg = new _420_StrongPasswordCheckerAlg();

        [TestMethod]
        public void TestCase01()
        {
            string password = "a";
            int exp = 5;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string password = "aA1";
            int exp = 3;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string password = "1337C0d3";
            int exp = 0;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string password = "aa123";
            int exp = 1;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string password = "aaa111";
            int exp = 2;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string password = "aaaB1";
            int exp = 1;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            string password = "1111111111";
            int exp = 3;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string password = "bbaaaaaaaaaaaaaaacccccc";
            int exp = 8;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            string password = "aaaaAAAAAA000000123456";
            int exp = 5;
            int res = alg.StrongPasswordChecker(password);
            Assert.AreEqual(exp, res);
        }


    }
}
