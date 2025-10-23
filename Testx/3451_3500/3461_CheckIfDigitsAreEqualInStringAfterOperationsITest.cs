using leetCode._3451_3500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3451_3500
{
    public class _3461_CheckIfDigitsAreEqualInStringAfterOperationsITest
    {
        _3461_CheckIfDigitsAreEqualInStringAfterOperationsIAlg alg = new _3461_CheckIfDigitsAreEqualInStringAfterOperationsIAlg();

        [Fact]
        public void TestCase01()
        {
            string s = "3902";
            bool res = alg.HasSameDigits(s);
            bool exp = true;
            Assert.Equal(exp, res);
        }
        [Fact]
        public void TestCase02()
        {
            string s = "34789";
            bool res = alg.HasSameDigits(s);
            bool exp = false;
            Assert.Equal(exp, res);
        }
    }
}
