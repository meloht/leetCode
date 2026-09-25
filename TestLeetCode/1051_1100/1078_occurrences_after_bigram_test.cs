using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1051_1100
{
    [TestClass]
    public class _1078_occurrences_after_bigram_test
    {
        _1078_occurrences_after_bigram alg = new _1078_occurrences_after_bigram();

        [TestMethod]
        public void TestCase01()
        {
            string text = "alice is a good girl she is a good student", first = "a", second = "good";
            string[] exp = ["girl", "student"];
            string[] res = alg.FindOcurrences(text,first,second);
            Assert.AreSequenceEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            string text = text = "we will we will rock you", first = "we", second = "will";
            string[] exp = ["we", "rock"];
            string[] res = alg.FindOcurrences(text, first, second);
            Assert.AreSequenceEqual(exp, res);
        }

    }
}
