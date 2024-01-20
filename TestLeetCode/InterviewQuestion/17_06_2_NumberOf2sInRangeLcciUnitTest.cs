using leetCode.InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode.InterviewQuestion
{
    [TestClass]
    public class NumberOf2sInRangeLcciUnitTest
    {
        NumberOf2sInRangeLcciAlg alg = new NumberOf2sInRangeLcciAlg();

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
