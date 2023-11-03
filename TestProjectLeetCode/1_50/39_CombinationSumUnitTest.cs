using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode._1_50;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _39_CombinationSumUnitTest
    {
        _39_CombinationSumAlg alg = new _39_CombinationSumAlg();

        private bool IsSame(IList<IList<int>> list, IList<IList<int>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            for (int i = 0; i < list.Count; i++)
            {
                var a = list[i];
                var b = list2[i];
                if (!a.SequenceEqual(b))
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void TestCase01()
        {
            var candidates = new int[] { 2, 3, 6, 7 };
            var res = alg.CombinationSum(candidates, 7);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 2, 2, 3 });
            list.Add(new[] { 7 });
            bool bl = IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            var candidates = new int[] { 2, 3, 5 };
            var res = alg.CombinationSum(candidates, 8);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 2, 2, 2, 2 });
            list.Add(new[] { 2, 3, 3 });
            list.Add(new[] { 3, 5 });
            bool bl = IsSame(list, res);
            Assert.AreEqual(true, bl);

        }
        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 2 };
            var res = alg.CombinationSum(candidates, 1);

            IList<IList<int>> list = new List<IList<int>>();

            bool bl = IsSame(list, res);
            Assert.AreEqual(true, bl);

        }
    }
}
