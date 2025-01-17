using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _775_GlobalAndLocalInversionsTest
    {
        _775_GlobalAndLocalInversionsAlg alg = new _775_GlobalAndLocalInversionsAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 0, 2];
            bool exp = true;
            bool res = alg.IsIdealPermutation(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 0];
            bool exp = false;
            bool res = alg.IsIdealPermutation(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 0, 1];
            bool exp = false;
            bool res = alg.IsIdealPermutation(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [2, 1, 0];
            bool exp = false;
            bool res = alg.IsIdealPermutation(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
