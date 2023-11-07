using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _41_FirstMissingPositiveUnitTest
    {
        _41_FirstMissingPositiveAlg alg = new _41_FirstMissingPositiveAlg();

        [TestMethod]
        public void TestCase01()
        {
            var candidates = new int[] { 1, 2, 0 };
            var res = alg.FirstMissingPositive(candidates);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var candidates = new int[] { 3, 4, -1, 1 };
            var res = alg.FirstMissingPositive(candidates);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 7, 8, 9, 11, 12 };
            var res = alg.FirstMissingPositive(candidates);
            Assert.AreEqual(1, res);
        }
    }
}
