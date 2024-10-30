using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3216_LexicographicallySmallestStringAfterASwapTest
    {
        _3216_LexicographicallySmallestStringAfterASwapAlg alg = new _3216_LexicographicallySmallestStringAfterASwapAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "45320";
            string exp = "43520";
            string res = alg.GetSmallestString(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "001";
            string exp = "001";
            string res = alg.GetSmallestString(s);
            Assert.AreEqual(exp, res);
        }
    }
}
