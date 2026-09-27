using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1201_1250
{
    [TestClass]
    public class _1221_split_a_string_in_balanced_strings_test
    {
        _1221_split_a_string_in_balanced_strings alg = new _1221_split_a_string_in_balanced_strings();


        [TestMethod]
        public void TestCase01()
        {
            string s = "RLRRLLRLRL";
            int exp = 4;
            int res = alg.BalancedStringSplit(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "RLRRRLLRLL";
            int exp = 2;
            int res = alg.BalancedStringSplit(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "LLLLRRRR";
            int exp = 1;
            int res = alg.BalancedStringSplit(s);
            Assert.AreEqual(exp, res);
        }
    }
}
