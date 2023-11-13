using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _49_GroupAnagramsUnitTest
    {
        _49_GroupAnagramsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _49_GroupAnagramsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> list = new List<IList<string>>();
            list.Add(new List<string>() { "bat" });
            list.Add(new List<string>() { "nat", "tan" });
            list.Add(new List<string>() { "ate", "eat", "tea" });

            var res = alg.GroupAnagrams(strs);

            bool bl = Utils.IsSameList(res, list);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var strs = new string[] { };
            IList<IList<string>> list = new List<IList<string>>();


            var res = alg.GroupAnagrams(strs);

            bool bl = Utils.IsSameList(res, list);
            Assert.AreEqual(true, bl);
        }
        [TestMethod]
        public void TestCase03()
        {
            var strs = new string[] { "a" };
            IList<IList<string>> list = new List<IList<string>>();
            list.Add(new List<string>() { "a" });

            var res = alg.GroupAnagrams(strs);

            bool bl = Utils.IsSameList(res, list);
            Assert.AreEqual(true, bl);
        }
    }
}
