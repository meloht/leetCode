using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2741_SpecialPermutationsTest
    {
        _2741_SpecialPermutationsAlg alg = new _2741_SpecialPermutationsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, 6];
            int exp = 2;
            int res = alg.SpecialPerm(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 3, 6];
            int exp = 2;
            int res = alg.SpecialPerm(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192];
            int exp = 178290591;
            int res = alg.SpecialPerm(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [20, 100, 50, 5, 10, 70, 7];
            int exp = 48;
            int res = alg.SpecialPerm(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
