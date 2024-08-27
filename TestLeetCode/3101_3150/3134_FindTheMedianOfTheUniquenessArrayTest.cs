using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3134_FindTheMedianOfTheUniquenessArrayTest
    {
        _3134_FindTheMedianOfTheUniquenessArrayAlg alg = new _3134_FindTheMedianOfTheUniquenessArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int exp = 1;
            int res = alg.MedianOfUniquenessArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 4, 3, 4, 5];
            int exp = 2;
            int res = alg.MedianOfUniquenessArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [4, 3, 5, 4];
            int exp = 2;
            int res = alg.MedianOfUniquenessArray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
