using leetCode._1651_1700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1651_1700
{
    [TestClass]
    public class _1673_FindTheMostCompetitiveSubsequenceUnitTest
    {
        _1673_FindTheMostCompetitiveSubsequenceAlg alg = new _1673_FindTheMostCompetitiveSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 5, 2, 6]; int k = 2;
            int[] exp = [2, 6];
            int[] res = alg.MostCompetitive(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 3, 3, 5, 4, 9, 6]; int k = 4;
            int[] exp = [2, 3, 3, 4];
            int[] res = alg.MostCompetitive(nums, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
