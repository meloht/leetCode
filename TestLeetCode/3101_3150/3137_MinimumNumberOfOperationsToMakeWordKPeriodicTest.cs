using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3137_MinimumNumberOfOperationsToMakeWordKPeriodicTest
    {
        _3137_MinimumNumberOfOperationsToMakeWordKPeriodicAlg alg = new _3137_MinimumNumberOfOperationsToMakeWordKPeriodicAlg();

        [TestMethod]
        public void TestCase01()
        {
            string word = "leetcodeleet";
            int k = 4;
            int exp = 1;
            int res = alg.MinimumOperationsToMakeKPeriodic(word, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string word = "leetcoleet";
            int k = 2;
            int exp = 3;
            int res = alg.MinimumOperationsToMakeKPeriodic(word, k);
            Assert.AreEqual(exp, res);
        }
    }
}
