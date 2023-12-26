using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _46_PermutationsUnitTest
    {
        _46_PermutationsAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _46_PermutationsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 1, 2, 3 };
            var res = alg.Permute(nums);
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
        public void TestCase02()
        {
            var nums = new int[] { 0, 1 };
            var res = alg.Permute(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 0, 1 });
            list.Add(new[] { 1, 0 });
            bool bl = Utils.IsSameList(list, res);
            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            var nums = new int[] { 1 };
            var res = alg.Permute(nums);
            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1 });

            bool bl = Utils.IsSameList(list, res);
            Assert.AreEqual(true, bl);
        }
    }
}
