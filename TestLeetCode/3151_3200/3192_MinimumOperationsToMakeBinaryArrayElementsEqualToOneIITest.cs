using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3192_MinimumOperationsToMakeBinaryArrayElementsEqualToOneIITest
    {
        _3192_MinimumOperationsToMakeBinaryArrayElementsEqualToOneIIAlg alg = new _3192_MinimumOperationsToMakeBinaryArrayElementsEqualToOneIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [0, 1, 1, 0, 1];
            int exp = 4;
            int res = alg.MinOperations(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 0, 0, 0];
            int exp = 1;
            int res = alg.MinOperations(nums);
            Assert.AreEqual(exp, res);
        }

       
    }
}
