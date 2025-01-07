using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3019_NumberOfChangingKeysTest
    {
        _3019_NumberOfChangingKeysAlg alg = new _3019_NumberOfChangingKeysAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aAbBcC";
            int exp = 2;
            int res = alg.CountKeyChanges(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "AaAaAaaA";
            int exp = 0;
            int res = alg.CountKeyChanges(s);
            Assert.AreEqual(exp, res);
        }
    }
}
