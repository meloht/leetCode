using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1201_1250
{
    [TestClass]
    public class _1207_unique_number_of_occurrences_test
    {
        _1207_unique_number_of_occurrences alg = new _1207_unique_number_of_occurrences();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [1, 2, 2, 1, 1, 3];
            bool exp = true;
            bool res = alg.UniqueOccurrences(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2];
            bool exp = false;
            bool res = alg.UniqueOccurrences(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
