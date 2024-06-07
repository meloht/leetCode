using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3038_MaximumNumberOfOperationsWithTheSameScoreIUnitTest
    {
        _3038_MaximumNumberOfOperationsWithTheSameScoreIAlg alg = new _3038_MaximumNumberOfOperationsWithTheSameScoreIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 2, 1, 4, 5];
            int exp = 2;
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
    }
}
