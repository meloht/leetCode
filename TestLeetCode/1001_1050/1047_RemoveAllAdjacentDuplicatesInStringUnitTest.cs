using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1047_RemoveAllAdjacentDuplicatesInStringUnitTest
    {
        _1047_RemoveAllAdjacentDuplicatesInStringAlg alg = new _1047_RemoveAllAdjacentDuplicatesInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abbaca";
            string exp = "ca";
            string res = alg.RemoveDuplicates(s);
            Assert.AreEqual(exp, res);
        }
    }
}
