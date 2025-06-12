using leetCode._3401_3450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3401_3450
{
    [TestClass]
    public class _3423_MaximumDifferenceBetweenAdjacentElementsInACircularArrayTest
    {
        _3423_MaximumDifferenceBetweenAdjacentElementsInACircularArrayAlg alg = new _3423_MaximumDifferenceBetweenAdjacentElementsInACircularArrayAlg();

        [TestMethod]
        public void Test01()
        {
            int[] nums = [1, 2, 4];
            int exp = 3;
            int res = alg.MaxAdjacentDistance(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] nums = [-5, -10, -5];
            int exp = 5;
            int res = alg.MaxAdjacentDistance(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
