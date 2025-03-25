using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _833_FindAndReplaceInStringTest
    {
        _833_FindAndReplaceInStringAlg alg = new _833_FindAndReplaceInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcd";
            int[] indices = [0, 2];
            string[] sources = ["a", "cd"], targets = ["eee", "ffff"];

            string exp = "eeebffff";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcd";
            int[] indices = [0, 2];
            string[] sources = ["ab", "ec"], targets = ["eee", "ffff"];

            string exp = "eeecd";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }
    }
}
