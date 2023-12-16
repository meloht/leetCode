using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _68_TextJustificationUnitTest
    {
        _68_TextJustificationAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _68_TextJustificationAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var words = new string[] { "This", "is", "an", "example", "of", "text", "justification." };
            var res = alg.FullJustify(words, 16);
            List<string> result = new List<string>()
            {
            "This    is    an",
            "example  of text",
            "justification.  "
            };
            Assert.AreEqual(true, result.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase02()
        {
            var words = new string[] { "What", "must", "be", "acknowledgment", "shall", "be" };
            var res = alg.FullJustify(words, 16);
            List<string> result = new List<string>()
            {
            "What   must   be",
            "acknowledgment  ",
            "shall be        "
            };
            Assert.AreEqual(true, result.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase03()
        {
            var words = new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            var res = alg.FullJustify(words, 20);
            List<string> result = new List<string>()
            {
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
            };
            Assert.AreEqual(true, result.SequenceEqual(res));
        }
    }
}
