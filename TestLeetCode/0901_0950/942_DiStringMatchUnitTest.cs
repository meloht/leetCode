using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _942_DiStringMatchUnitTest
    {
        _942_DiStringMatchAlg alg = new _942_DiStringMatchAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "IDID";
            int[] exp = [0, 4, 1, 3, 2];
            int[] res = alg.DiStringMatch(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "III";
            int[] exp = [0, 1, 2, 3];
            int[] res = alg.DiStringMatch(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "DDI";
            int[] exp = [3, 2, 0, 1];
            int[] res = alg.DiStringMatch(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
