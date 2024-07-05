using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _451_SortCharactersByFrequencyTest
    {
        _451_SortCharactersByFrequencyAlg alg = new _451_SortCharactersByFrequencyAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "tree";
            string exp = "eetr";
            string res = alg.FrequencySort(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cccaaa";
            string exp = "cccaaa";
            string res = alg.FrequencySort(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "Aabb";
            string exp = "bbAa";
            string res = alg.FrequencySort(s);
            Assert.AreEqual(exp, res);
        }
    }
}
