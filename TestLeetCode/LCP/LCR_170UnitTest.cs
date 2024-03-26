using leetCode.LCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LCP
{
    [TestClass]
    public class LCR_170UnitTest
    {
        LCR_170 alg = new LCR_170();

        [TestMethod]
        public void TestCase01()
        {
            int[] record = [9, 7, 5, 4, 6];
            int exp = 8;
            int res = alg.ReversePairs(record);
            Assert.AreEqual(exp, res);
        }
    }
}
