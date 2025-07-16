using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3201_FindTheMaximumLengthOfValidSubsequenceITest
    {
        _3201_FindTheMaximumLengthOfValidSubsequenceIAlg alg = new _3201_FindTheMaximumLengthOfValidSubsequenceIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            int exp = 4;
            int res = alg.MaximumLength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 1, 1, 2, 1, 2];
            int exp = 6;
            int res = alg.MaximumLength(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 3];
            int exp = 2;
            int res = alg.MaximumLength(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
