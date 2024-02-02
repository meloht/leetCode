using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _290_WordPatternUnitTest
    {
        _290_WordPatternAlg alg = new _290_WordPatternAlg();

        [TestMethod]
        public void TestCase01()
        {
            string pattern = "abba", s = "dog cat cat dog";
            bool exp = true;
            bool res = alg.WordPattern(pattern, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string pattern = "abba", s = "dog cat cat fish";
            bool exp = false;
            bool res = alg.WordPattern(pattern, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string pattern = "aaaa", s = "dog cat cat dog";
            bool exp = false;
            bool res = alg.WordPattern(pattern, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string pattern = "abba", s = "dog dog dog dog";
            bool exp = false;
            bool res = alg.WordPattern(pattern, s);
            Assert.AreEqual(exp, res);
        }
    }
}
