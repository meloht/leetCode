using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._0101_0150
{
    [TestClass]
    public class _115_DistinctSubsequencesUnitTest
    {
        _115_DistinctSubsequencesAlg alg = new _115_DistinctSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "rabbbit";
            string t = "rabbit";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 3);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "babgbag";
            string t = "bag";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 5);
        }
    }
}
