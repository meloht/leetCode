using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _848_ShiftingLettersTest
    {
        _848_ShiftingLettersAlg alg = new _848_ShiftingLettersAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abc";
            int[] shifts = [3, 5, 9];
            string exp = "rpl";
            string res = alg.ShiftingLetters(s, shifts);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "aaa";
            int[] shifts = [1, 2, 3];
            string exp = "gfd";
            string res = alg.ShiftingLetters(s, shifts);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "bad";
            int[] shifts = [10, 20, 30];
            string exp = "jyh";
            string res = alg.ShiftingLetters(s, shifts);
            Assert.AreEqual(exp, res);

        }
    }
}
