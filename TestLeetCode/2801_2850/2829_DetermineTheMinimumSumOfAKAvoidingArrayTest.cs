using leetCode._2801_2850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2801_2850
{
    [TestClass]
    public class _2829_DetermineTheMinimumSumOfAKAvoidingArrayTest
    {
        _2829_DetermineTheMinimumSumOfAKAvoidingArrayAlg alg = new _2829_DetermineTheMinimumSumOfAKAvoidingArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 5, k = 4;
            int exp = 18;
            int res = alg.MinimumSum(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 2, k = 6;
            int exp = 3;
            int res = alg.MinimumSum(n, k);
            Assert.AreEqual(exp, res);
        }
    }
}
