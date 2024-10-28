using leetCode._0551_0600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _553_OptimalDivisionTest
    {
        _553_OptimalDivisionAlg alg = new _553_OptimalDivisionAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1000, 100, 10, 2];
            string exp = "1000/(100/10/2)";
            string res = alg.OptimalDivision(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 3, 4];
            string exp = "2/(3/4)";
            string res = alg.OptimalDivision(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
