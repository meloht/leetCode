using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _944_DeleteColumnsToMakeSortedUnitTest
    {
        _944_DeleteColumnsToMakeSortedAlg alg = new _944_DeleteColumnsToMakeSortedAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] strs = ["cba", "daf", "ghi"];
            int exp = 1;
            int res = alg.MinDeletionSize(strs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] strs = ["a", "b"];
            int exp = 0;
            int res = alg.MinDeletionSize(strs);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] strs = ["zyx", "wvu", "tsr"];
            int exp = 3;
            int res = alg.MinDeletionSize(strs);
            Assert.AreEqual(exp, res);
        }
    }
}
