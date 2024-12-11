using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2717_SemiOrderedPermutationTest
    {
        _2717_SemiOrderedPermutationAlg alg = new _2717_SemiOrderedPermutationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 1, 4, 3];
            int exp = 2;
            int res = alg.SemiOrderedPermutation(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 1, 3];
            int exp = 3;
            int res = alg.SemiOrderedPermutation(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3, 4, 2, 5];
            int exp = 0;
            int res = alg.SemiOrderedPermutation(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
