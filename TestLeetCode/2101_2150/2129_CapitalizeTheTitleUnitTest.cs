using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2129_CapitalizeTheTitleUnitTest
    {
        _2129_CapitalizeTheTitleAlg alg = new _2129_CapitalizeTheTitleAlg();

        [TestMethod]
        public void TestCase01()
        {
            string title = "capiTalIze tHe titLe";
            string exp = "Capitalize The Title";
            string res = alg.CapitalizeTitle(title);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string title = "First leTTeR of EACH Word";
            string exp = "First Letter of Each Word";
            string res = alg.CapitalizeTitle(title);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string title = "i lOve leetcode";
            string exp = "i Love Leetcode";
            string res = alg.CapitalizeTitle(title);
            Assert.AreEqual(exp, res);
        }
    }
}
