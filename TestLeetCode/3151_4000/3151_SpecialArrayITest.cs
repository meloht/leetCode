using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3151_SpecialArrayITest
    {
        _3151_SpecialArrayIAlg alg = new _3151_SpecialArrayIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1];
            bool exp = true;
            bool res = alg.IsArraySpecial(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 1, 4];
            bool exp = true;
            bool res = alg.IsArraySpecial(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [4, 3, 1, 6];
            bool exp = false;
            bool res = alg.IsArraySpecial(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
