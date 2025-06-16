using leetCode._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2001_2050
{
    [TestClass]
    public class _2016_MaximumDifferenceBetweenIncreasingElementsTest
    {
        _2016_MaximumDifferenceBetweenIncreasingElementsAlg alg = new _2016_MaximumDifferenceBetweenIncreasingElementsAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [7, 1, 5, 4];
            int exp = 4;
            int res = alg.MaximumDifference(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [9, 4, 3, 2];
            int exp = -1;
            int res = alg.MaximumDifference(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] nums = [1, 5, 2, 10];
            int exp = 9;
            int res = alg.MaximumDifference(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
