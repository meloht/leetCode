using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _691_StickersToSpellWordTest
    {
        _691_StickersToSpellWordAlg alg = new _691_StickersToSpellWordAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] stickers = ["with", "example", "science"];
            string target = "thehat";
            int exp = 3;
            int res = alg.MinStickers(stickers, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] stickers = ["notice", "possible"];
            string target = "basicbasic";
            int exp = -1;
            int res = alg.MinStickers(stickers, target);
            Assert.AreEqual(exp, res);
        }
    }
}
