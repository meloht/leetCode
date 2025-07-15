using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3136_ValidWordTest
    {
        _3136_ValidWordAlg alg = new _3136_ValidWordAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "234Adas";
            bool exp = true;
            bool res = alg.IsValid(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "b3";
            bool exp = false;
            bool res = alg.IsValid(word);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string word = "a3$e";
            bool exp = false;
            bool res = alg.IsValid(word);
            Assert.AreEqual(exp, res);
        }
    }
}
