using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3040_MaximumNumberOfOperationsWithTheSameScoreIIUnitTest
    {
        _3040_MaximumNumberOfOperationsWithTheSameScoreIIAlg alg = new _3040_MaximumNumberOfOperationsWithTheSameScoreIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 1, 2, 3, 4];
            int exp = 3;
            int res = alg.MaxOperations(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 2, 6, 1, 4];
            int exp = 2;
            int res = alg.MaxOperations(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 2, 3, 2, 2, 1, 3, 3];
            int exp = 4;
            int res = alg.MaxOperations(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [3, 2, 3, 2, 2, 3, 3, 2, 4, 1];
            int exp = 5;
            int res = alg.MaxOperations(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
