using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _842_SplitArrayIntoFibonacciSequenceTest
    {
        _842_SplitArrayIntoFibonacciSequenceAlg alg = new _842_SplitArrayIntoFibonacciSequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "1101111";
            IList<int> exp = [11, 0, 11, 11];
            IList<int> res = alg.SplitIntoFibonacci(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "112358130";
            IList<int> exp = [];
            IList<int> res = alg.SplitIntoFibonacci(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string num = "0123";
            IList<int> exp = [];
            IList<int> res = alg.SplitIntoFibonacci(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase04()
        {
            string num = "74912134825162255812723932620170946950766784234934";
            IList<int> exp = [];
            IList<int> res = alg.SplitIntoFibonacci(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase05()
        {
            string num = "2820022842865610841740282445647388119521934031292";
            IList<int> exp = [28, 200, 228, 428, 656, 1084, 1740, 2824, 4564, 7388, 11952, 19340, 31292];
            IList<int> res = alg.SplitIntoFibonacci(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
