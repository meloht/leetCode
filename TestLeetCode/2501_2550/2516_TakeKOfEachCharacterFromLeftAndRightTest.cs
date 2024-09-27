using leetCode._2501_2550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2501_2550
{
    [TestClass]
    public class _2516_TakeKOfEachCharacterFromLeftAndRightTest
    {
        _2516_TakeKOfEachCharacterFromLeftAndRightAlg alg=new _2516_TakeKOfEachCharacterFromLeftAndRightAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aabaaaacaabc";
            int k = 2;
            int exp = 8;
            int res = alg.TakeCharacters(s, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            int k = 1;
            int exp = -1;
            int res = alg.TakeCharacters(s, k);
            Assert.AreEqual(exp, res);
        }
    }
}
