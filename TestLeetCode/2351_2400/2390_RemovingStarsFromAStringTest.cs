using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2351_2400
{
    [TestClass]
    public class _2390_RemovingStarsFromAStringTest
    {
        _2390_RemovingStarsFromAStringAlg alg = new _2390_RemovingStarsFromAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "leet**cod*e";
            string exp = "lecoe";
            string res = alg.RemoveStars(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "erase*****";
            string exp = "";
            string res = alg.RemoveStars(s);
            Assert.AreEqual(exp, res);
        }
    }
}
