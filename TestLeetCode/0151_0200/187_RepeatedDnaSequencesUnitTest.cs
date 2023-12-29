using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _187_RepeatedDnaSequencesUnitTest
    {
        _187_RepeatedDnaSequencesAlg alg = new _187_RepeatedDnaSequencesAlg();


        [TestMethod]
        public void TestCase01()
        {
            string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            string[] exp = ["AAAAACCCCC", "CCCCCAAAAA"];

            var res = alg.FindRepeatedDnaSequences(s);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "AAAAAAAAAAAAA";
            string[] exp = ["AAAAAAAAAA"];

            var res = alg.FindRepeatedDnaSequences(s);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
