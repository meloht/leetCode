using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2785_SortVowelsInAStringTest
    {
        _2785_SortVowelsInAStringAlg alg = new _2785_SortVowelsInAStringAlg();

        [TestMethod]
        public void Test01()
        {
            string s = "lEetcOde";
            string exp = "lEOtcede";
            string res = alg.SortVowels(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string s = "lYmpH";
            string exp = "lYmpH";
            string res = alg.SortVowels(s);
            Assert.AreEqual(exp, res);
        }
    }
}
