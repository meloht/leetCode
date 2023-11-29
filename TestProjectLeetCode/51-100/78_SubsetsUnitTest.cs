using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _78_SubsetsUnitTest
    {
        _78_SubsetsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _78_SubsetsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = { 1, 2, 3 };
            IList<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { });
            exp.Add(new[] { 1 });
            exp.Add(new[] { 2 });
            exp.Add(new[] { 1, 2 });
            exp.Add(new[] { 3 });
            exp.Add(new[] { 1, 3 });
            exp.Add(new[] { 2, 3 });
            exp.Add(new[] { 1, 2, 3 });

            var res = alg.Subsets(arr);
            bool bl = Utils.IsSame(exp, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = { 0 };
            IList<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { });
            exp.Add(new[] { 0 });

            var res = alg.Subsets(arr);
            bool bl = Utils.IsSame(exp, res);
            Assert.AreEqual(true, bl);
        }
    }
}
