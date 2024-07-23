using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3098_FindTheSumOfSubsequencePowersTest
    {
        _3098_FindTheSumOfSubsequencePowersAlg alg=new _3098_FindTheSumOfSubsequencePowersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            int k = 3;
            int exp = 4;
            int res=alg.SumOfPowers(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 2];
            int k = 2;
            int exp = 0;
            int res = alg.SumOfPowers(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [4, 3, -1];
            int k = 2;
            int exp = 10;
            int res = alg.SumOfPowers(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
