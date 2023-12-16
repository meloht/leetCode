using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1_50
{
    [TestClass]
    public class _40_CombinationSumIIUnitTest
    {

        _40_CombinationSumIIAlg alg = new _40_CombinationSumIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            var candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            var res = alg.CombinationSum2(candidates, 8);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1, 1, 6 });
            list.Add(new[] { 1, 2, 5 });
            list.Add(new[] { 1, 7 });
            list.Add(new[] { 2, 6 });
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }
        [TestMethod]
        public void TestCase02()
        {
            var candidates = new int[] { 2, 5, 2, 1, 2 };
            var res = alg.CombinationSum2(candidates, 5);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1, 2, 2 });
            list.Add(new[] { 5 });
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 1, 1 };
            var res = alg.CombinationSum2(candidates, 1);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1 });
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

      



        [TestMethod]
        public void TestCase04()
        {
           var candidates = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
           var res = alg.CombinationSum2(candidates, 30);

        }

        [TestMethod]
        public void TestCase05()
        {
            var candidates = new int[] { 1, 1, 1, 1 };
            var res = alg.CombinationSum2(candidates, 3);
        }

        [TestMethod]
        public void TestCase06()
        {
            var candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            var res = alg.CombinationSum2(candidates, 8);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1, 1, 6 });
            list.Add(new[] { 1, 2, 5 });
            list.Add(new[] { 1, 7 });
            list.Add(new[] { 2, 6 });
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

 
    }
}
