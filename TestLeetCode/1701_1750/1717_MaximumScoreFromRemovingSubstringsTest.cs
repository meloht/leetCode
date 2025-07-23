using leetCode._1701_1750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1701_1750
{
    [TestClass]
    public class _1717_MaximumScoreFromRemovingSubstringsTest
    {
        _1717_MaximumScoreFromRemovingSubstringsAlg alg = new _1717_MaximumScoreFromRemovingSubstringsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "cdbcbbaaabab";
            int x = 4, y = 5;
            int exp = 19;
            int res = alg.MaximumGain(s, x, y);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aabbaaxybbaabb";
            int x = 5, y = 4;
            int exp = 20;
            int res = alg.MaximumGain(s, x, y);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "aabbabkbbbfvybssbtaobaaaabataaadabbbmakgabbaoapbbbbobaabvqhbbzbbkapabaavbbeghacabamdpaaqbqabbjbababmbakbaabajabasaabbwabrbbaabbafubayaazbbbaababbaaha";
            int x = 1926, y = 4320;
            int exp = 112374;
            int res = alg.MaximumGain(s, x, y);
            Assert.AreEqual(exp, res);
        }
    }
}
