using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _118_PascalsTriangleUnitTest
    {
        _118_PascalsTriangleAlg alg = new _118_PascalsTriangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 1 });
            exp.Add(new int[] { 1, 1 });
            exp.Add(new int[] { 1, 2, 1 });
            exp.Add(new int[] { 1, 3, 3, 1 });
            exp.Add(new int[] { 1, 4, 6, 4, 1 });

            var res = alg.Generate(5);

            bool bl=Utils.IsSameList(exp,res);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            List<IList<int>> exp = new List<IList<int>>();
            exp.Add(new int[] { 1 });
            var res = alg.Generate(1);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
