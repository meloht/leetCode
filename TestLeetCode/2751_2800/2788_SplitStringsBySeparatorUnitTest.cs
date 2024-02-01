using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2788_SplitStringsBySeparatorUnitTest
    {
        _2788_SplitStringsBySeparatorAlg alg = new _2788_SplitStringsBySeparatorAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] words = ["one.two.three", "four.five", "six"];
            char separator = '.';

            string[] exp = ["one", "two", "three", "four", "five", "six"];
            var res = alg.SplitWordsBySeparator(words, separator);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] words = ["$easy$", "$problem$"];
            char separator = '$';

            string[] exp = ["easy", "problem"];
            var res = alg.SplitWordsBySeparator(words, separator);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] words = ["|||"];
            char separator = '|';

            string[] exp = [];
            var res = alg.SplitWordsBySeparator(words, separator);
            bool bl = exp.SequenceEqual(res);
            Assert.IsTrue(bl);
        }
    }
}
