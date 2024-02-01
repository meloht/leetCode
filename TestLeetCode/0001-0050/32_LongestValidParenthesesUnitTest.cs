using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0001_0050
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
            string s = "()(()";
            int num1 = 2;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s = "(()(((()";
            int num1 = 2;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase07()
        {
            string s = "()()(((()";
            int num1 = 4;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase08()
        {
            string s = "(()()(((()";
            int num1 = 4;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase09()
        {
            string s = ")(()((()))(((()()())";
            int num1 = 8;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }

        [TestMethod]
        public void TestCase10()
        {
            string s = ")(()(()(((())(((((()()))((((()()(()()())())())()))()()()())(())()()(((()))))()((()))(((())()((()()())((())))(())))())((()())()()((()((())))))((()(((((()((()))(()()(())))((()))()))())";

            int num1 = 132;
            int num2 = alg.LongestValidParentheses(s);
            Assert.AreEqual(num1, num2);
        }
    }
}
