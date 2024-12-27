using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3159_FindOccurrencesOfAnElementInAnArrayTest
    {
        _3159_FindOccurrencesOfAnElementInAnArrayAlg alg = new _3159_FindOccurrencesOfAnElementInAnArrayAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 1, 7], queries = [1, 3, 2, 4];
            int x = 1;
            int[] exp = [0, -1, 2, -1];
            int[] res = alg.OccurrencesOfElement(nums, queries, x);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3], queries = [10];
            int x = 5;
            int[] exp = [-1];
            int[] res = alg.OccurrencesOfElement(nums, queries, x);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
