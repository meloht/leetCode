using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
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
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            string[][] exp = [["a"]];
            var res = alg.Partition(s);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
