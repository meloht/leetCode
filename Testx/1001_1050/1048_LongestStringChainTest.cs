using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1048_LongestStringChainTest
    {
        _1048_LongestStringChainAlg alg = new _1048_LongestStringChainAlg();

        [Fact]
        public void Test1()
        {
            string[] words = ["a", "b", "ba", "bca", "bda", "bdca"];
            int exp = 4;
            int res = alg.LongestStrChain(words);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            string[] words = ["xbc", "pcxbcf", "xb", "cxbc", "pcxbc"];
            int exp = 5;
            int res = alg.LongestStrChain(words);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            string[] words = ["abcd", "dbqca"];
            int exp = 1;
            int res = alg.LongestStrChain(words);
            Assert.Equal(exp, res);
        }
    }
}
