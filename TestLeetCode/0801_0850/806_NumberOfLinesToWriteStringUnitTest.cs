using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _806_NumberOfLinesToWriteStringUnitTest
    {
        _806_NumberOfLinesToWriteStringAlg alg = new _806_NumberOfLinesToWriteStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] widths = [10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10];
            string s = "abcdefghijklmnopqrstuvwxyz";
            int[] exp = [3, 60];
            int[] res = alg.NumberOfLines(widths, s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] widths = [4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10];
            string s = "bbbcccdddaaa";
            int[] exp = [2, 4];
            int[] res = alg.NumberOfLines(widths, s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
