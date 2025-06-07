using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode._1001_1050;

namespace Testx._1001_1050
{
    public class _1016_BinaryStringWithSubstringsRepresenting1ToNTest
    {
        _1016_BinaryStringWithSubstringsRepresenting1ToNAlg alg = new _1016_BinaryStringWithSubstringsRepresenting1ToNAlg();
        [Fact]
        public void Test01()
        {
            string s = "0110";
            int n = 3;
            bool exp=true;
            bool res = alg.QueryString(s, n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "0110";
            int n = 4;
            bool exp = false;
            bool res = alg.QueryString(s, n);
            Assert.Equal(exp, res);
        }
    }
}
