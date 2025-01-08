using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _679_24GameTest
    {
        _679_24GameAlg alg = new _679_24GameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] cards = [4, 1, 8, 7];
            bool exp = true;
            bool res = alg.JudgePoint24(cards);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] cards = [1, 2, 1, 2];
            bool exp = false;
            bool res = alg.JudgePoint24(cards);
            Assert.AreEqual(exp, res);
        }
    }
}
