using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2246_LongestPathWithDifferentAdjacentCharactersUnitTest
    {
        _2246_LongestPathWithDifferentAdjacentCharactersAlg alg = new _2246_LongestPathWithDifferentAdjacentCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] parent = [-1, 0, 0, 1, 1, 2];
            string s = "abacbe";
            int exp = 3;
            int res = alg.LongestPath(parent, s);
            Assert.AreEqual(exp, res);  
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] parent = [-1, 0, 0, 0];
            string s = "aabc";
            int exp = 3;
            int res = alg.LongestPath(parent, s);
            Assert.AreEqual(exp, res);
        }
    }
}
