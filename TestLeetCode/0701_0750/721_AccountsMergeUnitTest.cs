using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _721_AccountsMergeUnitTest
    {
        _721_AccountsMergeAlg alg = new _721_AccountsMergeAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[][] accounts = [["John", "johnsmith@mail.com", "john00@mail.com"], ["John", "johnnybravo@mail.com"],
            ["John", "johnsmith@mail.com", "john_newyork@mail.com"], ["Mary", "mary@mail.com"]];
            IList<IList<string>> exp = [["John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com"],
            ["John", "johnnybravo@mail.com"], ["Mary", "mary@mail.com"]];

            IList<IList<string>> res = alg.AccountsMerge(accounts);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            string[][] accounts = [["Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe1@m.co"], ["Kevin", "Kevin3@m.co", "Kevin5@m.co", "Kevin0@m.co"], ["Ethan", "Ethan5@m.co", "Ethan4@m.co", "Ethan0@m.co"], 
            ["Hanzo", "Hanzo3@m.co", "Hanzo1@m.co", "Hanzo0@m.co"], ["Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co"]];
            IList<IList<string>> exp = [["Ethan", "Ethan0@m.co", "Ethan4@m.co", "Ethan5@m.co"], ["Gabe", "Gabe0@m.co", "Gabe1@m.co", "Gabe3@m.co"], ["Hanzo", "Hanzo0@m.co", "Hanzo1@m.co", "Hanzo3@m.co"],
            ["Kevin", "Kevin0@m.co", "Kevin3@m.co", "Kevin5@m.co"], ["Fern", "Fern0@m.co", "Fern1@m.co", "Fern5@m.co"]];

            IList<IList<string>> res = alg.AccountsMerge(accounts);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase03()
        {
            string[][] accounts = [["David", "David0@m.co", "David4@m.co", "David3@m.co"],
            ["David", "David5@m.co", "David5@m.co", "David0@m.co"], 
            ["David", "David1@m.co", "David4@m.co", "David0@m.co"],
            ["David", "David0@m.co", "David1@m.co", "David3@m.co"], 
            ["David", "David4@m.co", "David1@m.co", "David3@m.co"]];
            IList<IList<string>> exp = [["David", "David0@m.co", "David1@m.co",
                    "David3@m.co", "David4@m.co", "David5@m.co"]];

            IList<IList<string>> res = alg.AccountsMerge(accounts);

            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
