using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0984_StringWithoutAaaOrBbbTest
    {
        _0984_StringWithoutAaaOrBbbAlg alg = new _0984_StringWithoutAaaOrBbbAlg();

        [Fact]
        public void Test01()
        {
            int a = 1, b = 2;
            string exp = "bab";
            string res=alg.StrWithout3a3b(a, b);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int a = 4, b = 1;
            string exp = "aabaa";
            string res = alg.StrWithout3a3b(a, b);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int a = 1, b = 1;
            string exp = "ab";
            string res = alg.StrWithout3a3b(a, b);
            Assert.Equal(exp, res);
        }
        [Fact]
        public void Test04()
        {
            int a = 2, b = 3;
            string exp = "babab";
            string res = alg.StrWithout3a3b(a, b);
            Assert.Equal(exp, res);
        }
    }
}
