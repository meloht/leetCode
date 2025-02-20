using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _811_SubdomainVisitCountTest
    {
        _811_SubdomainVisitCountAlg alg = new _811_SubdomainVisitCountAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] cpdomains = ["9001 discuss.leetcode.com"];
            string[] exp = ["9001 leetcode.com", "9001 discuss.leetcode.com", "9001 com"];
            string[] res = alg.SubdomainVisits(cpdomains).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] cpdomains = ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"];
            string[] exp = ["901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com"];
            string[] res = alg.SubdomainVisits(cpdomains).ToArray();
            Assert.IsTrue(Utils.IsSameArr(exp, res));
        }
    }
}
