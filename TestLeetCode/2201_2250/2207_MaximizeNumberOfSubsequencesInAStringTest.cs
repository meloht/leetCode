using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2207_MaximizeNumberOfSubsequencesInAStringTest
    {
        _2207_MaximizeNumberOfSubsequencesInAStringAlg alg = new _2207_MaximizeNumberOfSubsequencesInAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string text = "abdcdbc", pattern = "ac";
            long exp = 4;
            long res = alg.MaximumSubsequenceCount(text, pattern);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string text = "aabb", pattern = "ab";
            long exp = 6;
            long res = alg.MaximumSubsequenceCount(text, pattern);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string text = "zigfj", pattern = "ju";
            long exp = 1;
            long res = alg.MaximumSubsequenceCount(text, pattern);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string text = "fwymvreuftzgrcrxczjacqovduqaiig", pattern = "yy";
            long exp = 1;
            long res = alg.MaximumSubsequenceCount(text, pattern);
            Assert.AreEqual(exp, res);
        }
    }
}
