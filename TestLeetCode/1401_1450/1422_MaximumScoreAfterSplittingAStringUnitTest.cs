using leetCode._1401_1450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1401_1450
{
    [TestClass]
    public class _1422_MaximumScoreAfterSplittingAStringUnitTest
    {
        _1422_MaximumScoreAfterSplittingAStringAlg alg = new _1422_MaximumScoreAfterSplittingAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "011101";
            int exp = 5;
            int res = alg.MaxScore(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "00111";
            int exp = 5;
            int res = alg.MaxScore(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "1111";
            int exp = 3;
            int res = alg.MaxScore(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "00";
            int exp = 1;
            int res = alg.MaxScore(s);
            Assert.AreEqual(exp, res);
        }
    }
}
