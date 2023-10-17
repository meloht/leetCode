using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _32_LongestValidParenthesesUnitTest
    {
        LongestValidParenthesesAlg alg = new();

        [TestMethod]
        public void TestCase01()
        {
            string s = "(()";
            int num1 = 2;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = ")()())";
            int num1 = 4;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "";
            int num1 = 0;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "()(())";
            int num1 = 6;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase05()
        {
            //string s = "()(())";
            //int num1 = 6;
            //int num2 = alg.LongestValidParentheses(s);
            //Assert.AreEqual(num1, num2);
        }
    }
}
