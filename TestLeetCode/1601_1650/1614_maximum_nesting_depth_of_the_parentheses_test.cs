using leetCode._1601_1650;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1601_1650
{
    [TestClass]
    public class _1614_maximum_nesting_depth_of_the_parentheses_test
    {
        _1614_maximum_nesting_depth_of_the_parentheses alg = new _1614_maximum_nesting_depth_of_the_parentheses();

        [TestMethod]
        public void Test01()
        {
            string s = "(1+(2*3)+((8)/4))+1";
            int exp = 3;
            int res = alg.MaxDepth(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string s = "(1)+((2))+(((3)))";
            int exp = 3;
            int res = alg.MaxDepth(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            string s = "()(())((()()))";
            int exp = 3;
            int res = alg.MaxDepth(s);
            Assert.AreEqual(exp, res);
        }
    }
}
