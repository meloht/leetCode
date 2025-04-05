using leetCode._0851_0900;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _880_DecodedStringAtIndexTest
    {
        _880_DecodedStringAtIndexAlg alg = new _880_DecodedStringAtIndexAlg();
        [Fact]
        public void Test01()
        {
            string s = "leet2code3";
            int k = 10;
            string exp = "o";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "ha22";
            int k = 5;
            string exp = "h";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string s = "a2345678999999999999999";
            int k = 1;
            string exp = "a";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            string s = "y959q969u3hb22odq595";
            int k = 222280369;
            string exp = "y";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            string s = "a2b3c4d5e6f7g8h9";
            int k = 9;
            string exp = "b";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test06()
        {
            string s = "ajx37";
            int k = 18;
            string exp = "x";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test07()
        {
            string s = "ajx37nyx97niysdrzice4petvcvmcgqn282zicpbx6okybw93vhk782unctdbgmcjmbqn25rorktmu5ig2qn2y4xagtru2nehmsp";
            int k = 976159152;
            string exp = "x";
            string res = alg.DecodeAtIndex(s, k);
            Assert.Equal(exp, res);
        }
    }
}
