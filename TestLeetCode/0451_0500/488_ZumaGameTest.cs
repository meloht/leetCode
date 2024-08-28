using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _488_ZumaGameTest
    {
        _488_ZumaGameAlg alg = new _488_ZumaGameAlg();
        [TestMethod]
        public void TestCase01()
        {
            string board = "WRRBBW", hand = "RB";
            int exp = -1;
            int res = alg.FindMinStep(board, hand);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string board = "WWRRBBWW", hand = "WRBRW";
            int exp = 2;
            int res = alg.FindMinStep(board, hand);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string board = "G", hand = "GGGGG";
            int exp = 2;
            int res = alg.FindMinStep(board, hand);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string board = "RBYYBBRRB", hand = "YRBGB";
            int exp = 3;
            int res = alg.FindMinStep(board, hand);
            Assert.AreEqual(exp, res);
        }
    }
}
