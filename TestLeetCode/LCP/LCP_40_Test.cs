using leetCode.LCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LCP
{
    [TestClass]
    public class LCP_40_Test
    {
        LCP_40 alg = new LCP_40();

        [TestMethod]
        public void TestCase01()
        {
            int[] cards = [1, 2, 8, 9];
            int cnt = 3;
            int exp = 18;
            int res = alg.MaxmiumScore(cards, cnt);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] cards = [3, 3, 1];
            int cnt = 1;
            int exp = 0;
            int res = alg.MaxmiumScore(cards, cnt);
            Assert.AreEqual(exp, res);
        }


    }
}
