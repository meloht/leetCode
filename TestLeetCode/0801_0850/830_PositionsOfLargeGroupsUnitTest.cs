using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _830_PositionsOfLargeGroupsUnitTest
    {
        _830_PositionsOfLargeGroupsAlg alg = new _830_PositionsOfLargeGroupsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abbxxxxzzy";
            IList<IList<int>> exp = [[3, 6]];
            IList<IList<int>> res = alg.LargeGroupPositions(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abc";
            IList<IList<int>> exp = [];
            IList<IList<int>> res = alg.LargeGroupPositions(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcdddeeeeaabbbcd";
            IList<IList<int>> exp = [[3, 5], [6, 9], [12, 14]];
            IList<IList<int>> res = alg.LargeGroupPositions(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "aba";
            IList<IList<int>> exp = [];
            IList<IList<int>> res = alg.LargeGroupPositions(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
