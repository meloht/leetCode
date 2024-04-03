using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _500_KeyboardRowUnitTest
    {
        _500_KeyboardRowAlg alg = new _500_KeyboardRowAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["Hello", "Alaska", "Dad", "Peace"];
            string[] exp = ["Alaska", "Dad"];
            string[] res = alg.FindWords(words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["omk"];
            string[] exp = [];
            string[] res = alg.FindWords(words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["adsdf", "sfd"];
            string[] exp = ["adsdf", "sfd"];
            string[] res = alg.FindWords(words);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
