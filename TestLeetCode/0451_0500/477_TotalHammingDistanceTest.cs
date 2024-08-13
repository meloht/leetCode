using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _477_TotalHammingDistanceTest
    {
        _477_TotalHammingDistanceAlg alg = new _477_TotalHammingDistanceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 14, 2];
            int exp = 6;
            int res = alg.TotalHammingDistance(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 14, 4];
            int exp = 4;
            int res = alg.TotalHammingDistance(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
