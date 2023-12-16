using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _77_CombinationsUnitTest
    {
        _77_CombinationsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _77_CombinationsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int n = 4;
            int k = 2;
            IList<IList<int>> exp = new List<IList<int>>();
            exp.Add(new[] { 2, 4 });
            exp.Add(new[] { 3, 4 });
            exp.Add(new[] { 2, 3 });
            exp.Add(new[] { 1, 2 });
            exp.Add(new[] { 1, 3 });
            exp.Add(new[] { 1, 4 });

            var res = alg.Combine(n, k);
            bool bl = Utils.IsSame(exp, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int k = 1;
            IList<IList<int>> exp = new List<IList<int>>();
            exp.Add(new[] { 1 });

            var res = alg.Combine(n, k);
            bool bl = Utils.IsSame(exp, res);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 20;
            int k = 4;
            var res = alg.Combine(n, k);
         
        }
    }
}
