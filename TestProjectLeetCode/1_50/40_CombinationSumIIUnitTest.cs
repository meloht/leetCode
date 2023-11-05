using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _40_CombinationSumIIUnitTest
    {

        _40_CombinationSumIIAlg alg = new _40_CombinationSumIIAlg();

        private bool IsSame(IList<IList<int>> list, IList<IList<int>> list2)
        {
            //if (list.Count != list2.Count)
            //    return false;

            int count = 0;
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();
                b.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {

                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();
                    a.Sort();

                    if (a.SequenceEqual(b))
                    {
                        count++;

                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
            return false;
        }


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
            bool bl = IsSame(list, res);
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
            bool bl = IsSame(list, res);
            Assert.AreEqual(true, bl);

        }

        [TestMethod]
        public void TestCase03()
        {
            var candidates = new int[] { 1, 1 };
            var res = alg.CombinationSum2(candidates, 1);

            IList<IList<int>> list = new List<IList<int>>();
            list.Add(new[] { 1 });
            list.Add(new[] { 1 });
            bool bl = IsSame(list, res);
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
    }
}
