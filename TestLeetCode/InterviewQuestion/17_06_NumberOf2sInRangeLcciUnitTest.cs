using leetCode.InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.InterviewQuestion
{
    [TestClass]
    public class _17_06_NumberOf2sInRangeLcciUnitTest
    {
        _17_06_NumberOf2sInRangeLcciAlg alg = new _17_06_NumberOf2sInRangeLcciAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 25;
            int exp = 9;
            int res = alg.NumberOf2sInRange(n);
            Assert.AreEqual(exp, res);
        }

       
    }
}
