using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _722_RemoveCommentsTest
    {
        _722_RemoveCommentsAlg alg = new _722_RemoveCommentsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] source = ["/*Test program */", "int main()", "{ ", "  // variable declaration ", "int a, b, c;", "/* This is a test", "   multiline  ", "   comment for ", "   testing */", "a = b + c;", "}"];
            string[] exp = ["int main()", "{ ", "  ", "int a, b, c;", "a = b + c;", "}"];

            string[] res = alg.RemoveComments(source).ToArray();

            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            string[] source = ["a/*comment", "line", "more_comment*/b"];
            string[] exp = ["ab"];

            string[] res = alg.RemoveComments(source).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
