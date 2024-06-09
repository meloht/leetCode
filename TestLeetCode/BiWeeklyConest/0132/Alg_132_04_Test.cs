
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.BiWeeklyConest.bi_132;

namespace Test.BiWeeklyConest._0132
{
    [TestClass]
    public class Alg_132_04_Test
    {
        Alg_132_04 alg = new Alg_132_04();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 1, 1, 3];
            int k = 2;
            int exp = 4;
            int res = alg.MaximumLength(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5, 1];
            int k = 0;
            int exp = 2;
            int res = alg.MaximumLength(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {

        }

        [TestMethod]
        public void TestCase04()
        {

        }
    }
}
