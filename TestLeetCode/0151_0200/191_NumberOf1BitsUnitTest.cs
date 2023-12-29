using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _191_NumberOf1BitsUnitTest
    {
        _191_NumberOf1BitsAlg alg = new _191_NumberOf1BitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            uint n = Convert.ToUInt32("00000000000000000000000000001011", 2);
            var res = alg.HammingWeight(n);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            uint n = Convert.ToUInt32("00000000000000000000000010000000", 2);
            var res = alg.HammingWeight(n);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            uint n = Convert.ToUInt32("11111111111111111111111111111101", 2);
            var res = alg.HammingWeight(n);
            Assert.AreEqual(31, res);
        }
    }
}
