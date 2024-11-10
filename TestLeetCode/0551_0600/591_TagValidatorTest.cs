using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _591_TagValidatorTest
    {
        _591_TagValidatorAlg alg = new _591_TagValidatorAlg();

        [TestMethod]
        public void TestCase01()
        {
            string code = "<DIV>This is the first line <![CDATA[<div>]]></DIV>";
            bool exp = true;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string code = "<DIV>>>  ![cdata[]] <![CDATA[<div>]>]]>]]>>]</DIV>";
            bool exp = true;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string code = "<A>  <B> </A>   </B>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string code = "<DIV>  div tag is not closed  <DIV>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string code = "<DIV>  unmatched <  </DIV>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string code = "<DIV> closed tags with invalid tag name  <b>123</b> </DIV>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase07()
        {
            string code = "<DIV> unmatched tags with invalid tag name  </1234567890> and <CDATA[[]]>  </DIV>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string code = "<DIV>  unmatched start tag <B>  and unmatched end tag </C>  </DIV>";
            bool exp = false;
            bool res = alg.IsValid(code);
            Assert.AreEqual(exp, res);
        }
    }
}
