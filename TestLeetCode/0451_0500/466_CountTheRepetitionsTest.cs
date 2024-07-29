using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _466_CountTheRepetitionsTest
    {
        _466_CountTheRepetitionsAlg alg = new _466_CountTheRepetitionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s1 = "acb";
            int n1 = 4;
            string s2 = "ab";
            int n2 = 2;
            int exp = 2;
            int res = alg.GetMaxRepetitions(s1, n1, s2, n2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s1 = "acb";
            int n1 = 1;
            string s2 = "acb";
            int n2 = 1;
            int exp = 1;
            int res = alg.GetMaxRepetitions(s1, n1, s2, n2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s1 = "baba";
            int n1 = 11;
            string s2 = "baab";
            int n2 = 1;
            int exp = 7;
            int res = alg.GetMaxRepetitions(s1, n1, s2, n2);
            Assert.AreEqual(exp, res);
        }
    }
}
