using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2938_SeparateBlackAndWhiteBallsUnitTest
    {
        _2938_SeparateBlackAndWhiteBallsAlg alg = new _2938_SeparateBlackAndWhiteBallsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "101";
            int exp = 1;
            long res = alg.MinimumSteps(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "100";
            int exp = 2;
            long res = alg.MinimumSteps(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "0111";
            int exp = 0;
            long res = alg.MinimumSteps(s);
            Assert.AreEqual(exp, res);
        }
    }
}
