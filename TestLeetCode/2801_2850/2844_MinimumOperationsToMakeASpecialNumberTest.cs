using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2844_MinimumOperationsToMakeASpecialNumberTest
    {
        _2844_MinimumOperationsToMakeASpecialNumberAlg alg = new _2844_MinimumOperationsToMakeASpecialNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "2245047";
            int exp = 2;
            int res = alg.MinimumOperations(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "2908305";
            int exp = 3;
            int res = alg.MinimumOperations(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string num = "10";
            int exp = 1;
            int res = alg.MinimumOperations(num);
            Assert.AreEqual(exp, res);
        }
    }
}
