using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _131_PalindromePartitioningUnitTest
    {
        _131_PalindromePartitioningAlg alg = new _131_PalindromePartitioningAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aab";
            string[][] exp = [["a", "a", "b"], ["aa", "b"]];
            var res = alg.Partition(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            string[][] exp = [["a"]];
            var res = alg.Partition(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "cbbbcc";
            string[][] exp = [["c", "b", "b", "b", "c", "c"], ["c", "b", "b", "b", "cc"], ["c", "b", "bb", "c", "c"], ["c", "b", "bb", "cc"], ["c", "bb", "b", "c", "c"], ["c", "bb", "b", "cc"], ["c", "bbb", "c", "c"], ["c", "bbb", "cc"], ["cbbbc", "c"]];
            var res = alg.Partition(s);
            bool bl = Utils.IsSameList(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "ssssssssssssss";
            string[][] exp = [["c", "b", "b", "b", "c", "c"], ["c", "b", "b", "b", "cc"], ["c", "b", "bb", "c", "c"], ["c", "b", "bb", "cc"], ["c", "bb", "b", "c", "c"], ["c", "bb", "b", "cc"], ["c", "bbb", "c", "c"], ["c", "bbb", "cc"], ["cbbbc", "c"]];
            var res = alg.Partition(s);
            //bool bl = Utils.IsSameList(exp, res);
            //Assert.IsTrue(bl);
        }
    }
}
