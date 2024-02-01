using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2182_ConstructStringWithRepeatLimitUnitTest
    {
        _2182_ConstructStringWithRepeatLimitAlg alg = new _2182_ConstructStringWithRepeatLimitAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "cczazcc";
            int repeatLimit = 3;
            string exp = "zzcccac";
            string res = alg.RepeatLimitedString(s, repeatLimit);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string s = "aababab";
            int repeatLimit = 2;
            string exp = "bbabaa";
            string res = alg.RepeatLimitedString(s, repeatLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "xyutfpopdynbadwtvmxiemmusevduloxwvpkjioizvanetecnuqbqqdtrwrkgt";
            int repeatLimit = 1;
            string exp = "zyxyxwxwvwvuvuvututstrtrtqpqpqponononmlmkmkjigifiededededcbaba";
            string res = alg.RepeatLimitedString(s, repeatLimit);
            Assert.AreEqual(exp, res);
        }
    }
}
