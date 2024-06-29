using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2710_RemoveTrailingZerosFromAStringTest
    {
        _2710_RemoveTrailingZerosFromAStringAlg alg = new _2710_RemoveTrailingZerosFromAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "51230100";
            string exp = "512301";
            string res = alg.RemoveTrailingZeros(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "123";
            string exp = "123";
            string res = alg.RemoveTrailingZeros(num);
            Assert.AreEqual(exp, res);
        }
    }
}
