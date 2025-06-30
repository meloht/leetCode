using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2138_DivideAStringIntoGroupsOfSizeKTest
    {
        _2138_DivideAStringIntoGroupsOfSizeKAlg alg = new _2138_DivideAStringIntoGroupsOfSizeKAlg();
        [TestMethod]
        public void TestCase01()
        {
            string s = "abcdefghi";
            int k = 3;
            char fill = 'x';
            string[] exp = ["abc", "def", "ghi"];
            string[] res = alg.DivideString(s, k, fill);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcdefghij";
            int k = 3;
            char fill = 'x';
            string[] exp = ["abc", "def", "ghi", "jxx"];
            string[] res = alg.DivideString(s, k, fill);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "ctoyjrwtngqwt";
            int k = 8;
            char fill = 'n';
            string[] exp = ["ctoyjrwt", "ngqwtnnn"];
            string[] res = alg.DivideString(s, k, fill);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
