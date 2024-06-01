using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _388_LongestAbsoluteFilePathUnitTest
    {
        _388_LongestAbsoluteFilePathAlg alg = new _388_LongestAbsoluteFilePathAlg();

        [TestMethod]
        public void TestCase01()
        {
            string input = "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext";
            int exp = 20;
            int res = alg.LengthLongestPath(input);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string input = "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext";
            int exp = 32;
            int res = alg.LengthLongestPath(input);
            Assert.AreEqual(exp, res);
        }
    }
}
