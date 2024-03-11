using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _434_NumberOfSegmentsInAStringUnitTest
    {
        _434_NumberOfSegmentsInAStringAlg alg = new _434_NumberOfSegmentsInAStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "Hello, my name is John";
            int exp = 5;
            int res = alg.CountSegments(s);
            Assert.AreEqual(exp, res);
        }
    }
}
