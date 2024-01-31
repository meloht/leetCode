using leetCode._2401_2450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2401_2450
{
    [TestClass]
    public class _2413_SmallestEvenMultipleUnitTest
    {
        _2413_SmallestEvenMultipleAlg alg = new _2413_SmallestEvenMultipleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int exp = 10;
            int res = alg.SmallestEvenMultiple(5);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int exp = 6;
            int res = alg.SmallestEvenMultiple(6);
            Assert.AreEqual(exp, res);
        }
    }
}
