using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _423_ReconstructOriginalDigitsFromEnglishTest
    {
        _423_ReconstructOriginalDigitsFromEnglishAlg alg = new _423_ReconstructOriginalDigitsFromEnglishAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "owoztneoer";
            string exp = "012";
            string res = alg.OriginalDigits(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "fviefuro";
            string exp = "45";
            string res = alg.OriginalDigits(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "zeroonetwothreefourfivesixseveneightnine";
            string exp = "0123456789";
            string res = alg.OriginalDigits(s);
            Assert.AreEqual(exp, res);
        }
    }
}
