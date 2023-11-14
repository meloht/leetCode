using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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


        [TestMethod]
        public void TestCase01()
        {
            var candidates = new int[] { 2, 3, 6, 7 };
            var res = alg.CombinationSum(candidates, 7);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 2, 2, 3 });
            list.Add(new[] { 7 });
            bool bl = Utils.IsSame(list, res);
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
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }
        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 2 };
            var res = alg.CombinationSum(candidates, 1);

            IList<IList<int>> list = new List<IList<int>>();

            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase04()
        {
            var candidates = new int[] { 3, 5, 8 };
            var res = alg.CombinationSum(candidates, 11);

            IList<IList<int>> list = new List<IList<int>>();

            list.Add(new[] { 3, 3, 5 });
            list.Add(new[] { 3, 8 });
            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase05()
        {
            var candidates = new int[] { 8, 7, 4, 3 };
            var res = alg.CombinationSum(candidates, 11);

            IList<IList<int>> list = new List<IList<int>>();

            list.Add(new[] { 8, 3 });
            list.Add(new[] { 7, 4 });
            list.Add(new[] { 4, 4, 3 });

            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase06()
        {
            var candidates = new int[] { 7, 3, 2 };
            var res = alg.CombinationSum(candidates, 18);

            IList<IList<int>> list = new List<IList<int>>();

            list.Add(new[] { 7, 7, 2, 2 });
            list.Add(new[] { 7, 3, 3, 3, 2 });
            list.Add(new[] { 7, 3, 2, 2, 2, 2 });
            list.Add(new[] { 3, 3, 3, 3, 3, 3 });
            list.Add(new[] { 3, 3, 3, 3, 2, 2, 2 });
            list.Add(new[] { 3, 3, 2, 2, 2, 2, 2, 2 });
            list.Add(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 });

            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase07()
        {
            var candidates = new int[] { 4, 5, 2 };
            var res = alg.CombinationSum(candidates, 16);

            IList<IList<int>> list = new List<IList<int>>();

            list.Add(new[] { 4, 4, 4, 4 });
            list.Add(new[] { 4, 4, 4, 2, 2 });
            list.Add(new[] { 4, 4, 2, 2, 2, 2 });
            list.Add(new[] { 4, 5, 5, 2 });
            list.Add(new[] { 4, 2, 2, 2, 2, 2, 2 });
            list.Add(new[] { 5, 5, 2, 2, 2 });
            list.Add(new[] { 2, 2, 2, 2, 2, 2, 2, 2 });

            bool bl = Utils.IsSame(list, res);
            Assert.AreEqual(true, bl);

        }


        [TestMethod]
        public void TestCase08()
        {
            var candidates = new int[] { 5, 10, 8, 4, 3, 12, 9 };
            var res = alg.CombinationSum(candidates, 27);

            IList<IList<int>> list = new List<IList<int>>();

            list.Add(new[] { 5, 5, 5, 5, 4, 3 });
            list.Add(new[] { 5, 5, 5, 8, 4 });
            list.Add(new[] { 5, 5, 5, 4, 4, 4 });
            list.Add(new[] { 5, 5, 5, 3, 3, 3, 3 });
            list.Add(new[] { 5, 5, 5, 3, 9 });
            
            list.Add(new[] { 5, 5, 5, 12 });
            list.Add(new[] { 5, 5, 10, 4, 3 });
            list.Add(new[] { 5, 5, 8, 3, 3, 3 });
            list.Add(new[] { 5, 5, 8, 9 });
            list.Add(new[] { 5, 5, 4, 4, 3, 3, 3 });


            list.Add(new[] { 5, 5, 4, 4, 9 });
            list.Add(new[] { 5, 10, 8, 4 });
            list.Add(new[] { 5, 10, 4, 4, 4 });
            list.Add(new[] { 5, 10, 3, 3, 3, 3 });
            list.Add(new[] { 5, 10, 3, 9 });
            
            list.Add(new[] { 5, 10, 12 });
            list.Add(new[] { 5, 8, 8, 3, 3 });
            list.Add(new[] { 5, 8, 4, 4, 3, 3 });
            list.Add(new[] { 5, 4, 4, 4, 4, 3, 3 });
            list.Add(new[] { 5, 4, 3, 3, 3, 3, 3, 3 });
            
            list.Add(new[] { 5, 4, 3, 3, 3, 9 });
            list.Add(new[] { 5, 4, 3, 3, 12 });
            list.Add(new[] { 5, 4, 9, 9 });
            list.Add(new[] { 10, 10, 4, 3 });
            list.Add(new[] { 10, 8, 3, 3, 3 });

            list.Add(new[] { 10, 8, 9 });
            list.Add(new[] { 10, 4, 4, 3, 3, 3 });
            list.Add(new[] { 10, 4, 4, 9 });
            list.Add(new[] { 8, 8, 8, 3 });
            list.Add(new[] { 8, 8, 4, 4, 3 });

            list.Add(new[] { 8, 4, 4, 4, 4, 3 });
            list.Add(new[] { 8, 4, 3, 3, 3, 3, 3 });
            list.Add(new[] { 8, 4, 3, 3, 9 });
            list.Add(new[] { 8, 4, 3, 12 });
            list.Add(new[] { 4, 4, 4, 4, 4, 4, 3 });

            list.Add(new[] { 4, 4, 4, 3, 3, 3, 3, 3 });
            list.Add(new[] { 4, 4, 4, 3, 3, 9 });
            list.Add(new[] { 4, 4, 4, 3, 12 });
            list.Add(new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3 });
            list.Add(new[] { 3, 3, 3, 3, 3, 3, 9 });

            list.Add(new[] { 3, 3, 3, 3, 3, 12 });
            list.Add(new[] { 3, 3, 3, 9, 9 });
            list.Add(new[] { 3, 3, 12, 9 });
            list.Add(new[] { 3, 12, 12 });
            list.Add(new[] { 9, 9, 9 });


            bool bl = Utils.IsSame(list, res);

          
            Assert.AreEqual(true, bl);

        }
    }
}
