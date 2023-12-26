using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _96_UniqueBinarySearchTreesUnitTest
    {
        _96_UniqueBinarySearchTreesAlg alg = new _96_UniqueBinarySearchTreesAlg();
        [TestMethod]
        public void TestCase01()
        {
            int res=alg.NumTrees(3);
            int exp = 5;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int res = alg.NumTrees(1);
            int exp = 1;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int res = alg.NumTrees(2);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int res = alg.NumTrees(4);
            int exp = 14;
            Assert.AreEqual(exp, res);
        }
    }
}
