using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _312_BurstBalloonsUnitTest
    {
        _312_BurstBalloonsAlg alg = new _312_BurstBalloonsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 1, 5, 8];
            int exp = 167;
            int res = alg.MaxCoins(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 5];
            int exp = 10;
            int res = alg.MaxCoins(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
