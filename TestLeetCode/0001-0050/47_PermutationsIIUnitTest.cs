using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _47_PermutationsIIUnitTest
    {
        _47_PermutationsIIAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _47_PermutationsIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 1, 1, 2 };
            var res = alg.PermuteUnique(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1, 1, 2 });
            list.Add(new[] { 1, 2, 1 });
            list.Add(new[] { 2, 1, 1 });


            bool bl = Utils.IsSameList(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[] { 1, 2, 3 };
            var res = alg.PermuteUnique(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1, 2, 3 });
            list.Add(new[] { 1, 3, 2 });
            list.Add(new[] { 2, 1, 3 });
            list.Add(new[] { 2, 3, 1 });
            list.Add(new[] { 3, 1, 2 });
            list.Add(new[] { 3, 2, 1 });

            bool bl = Utils.IsSameList(list, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            var nums = new int[] { 3, 3, 0, 3 };
            var res = alg.PermuteUnique(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 0, 3, 3, 3 });
            list.Add(new[] { 3, 0, 3, 3 });
            list.Add(new[] { 3, 3, 0, 3 });
            list.Add(new[] { 3, 3, 3, 0 });

            bool bl = Utils.IsSameList(list, res);
            Assert.AreEqual(true, bl);
        }
    }
}
