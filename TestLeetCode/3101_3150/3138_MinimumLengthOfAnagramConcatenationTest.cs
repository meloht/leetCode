using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3138_MinimumLengthOfAnagramConcatenationTest
    {
        _3138_MinimumLengthOfAnagramConcatenationAlg alg = new _3138_MinimumLengthOfAnagramConcatenationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abba";
            int exp = 2;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "cdef";
            int exp = 4;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "aabb";
            int exp = 4;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "aabbbb";
            int exp = 6;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "abbbaa";
            int exp = 6;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string s = "jjj";
            int exp = 1;
            int res = alg.MinAnagramLength(s);
            Assert.AreEqual(exp, res);
        }
    }
}
