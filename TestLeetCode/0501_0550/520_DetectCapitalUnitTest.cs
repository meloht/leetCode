using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _520_DetectCapitalUnitTest
    {
        _520_DetectCapitalAlg alg = new _520_DetectCapitalAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "USA";
            bool exp = true;
            bool res=alg.DetectCapitalUse(word);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string word = "FlaG";
            bool exp = false;
            bool res = alg.DetectCapitalUse(word);
            Assert.AreEqual(exp, res);
        }
    }
}
