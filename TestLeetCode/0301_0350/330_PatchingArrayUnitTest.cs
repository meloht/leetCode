using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _330_PatchingArrayUnitTest
    {
        _330_PatchingArrayAlg alg = new _330_PatchingArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3];
            int n = 6;
            int exp = 1;
            int res = alg.MinPatches(nums, n);
            Assert.AreEqual(exp, res);
                
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 5, 10];
            int n = 20;
            int exp = 2;
            int res = alg.MinPatches(nums, n);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 2];
            int n = 5;
            int exp = 0;
            int res = alg.MinPatches(nums, n);
            Assert.AreEqual(exp, res);

        }
    }
}
