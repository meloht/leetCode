using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _831_MaskingPersonalInformationTest
    {
        _831_MaskingPersonalInformationAlg alg = new _831_MaskingPersonalInformationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "LeetCode@LeetCode.com";
            string exp = "l*****e@leetcode.com";
            string res = alg.MaskPII(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "AB@qq.com";
            string exp = "a*****b@qq.com";
            string res = alg.MaskPII(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "1(234)567-890";
            string exp = "***-***-7890";
            string res = alg.MaskPII(s);
            Assert.AreEqual(exp, res);
        }
    }
}
