using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0955_DeleteColumnsToMakeSortedIITest
    {
        _0955_DeleteColumnsToMakeSortedIIAlg alg = new _0955_DeleteColumnsToMakeSortedIIAlg();

        [Fact]
        public void Test01()
        {
            string[] strs = ["ca", "bb", "ac"];
            int exp = 1;
            int res = alg.MinDeletionSize(strs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] strs = ["xc", "yb", "za"];
            int exp = 0;
            int res = alg.MinDeletionSize(strs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] strs = ["zyx", "wvu", "tsr"];
            int exp = 3;
            int res = alg.MinDeletionSize(strs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            string[] strs = ["abx", "agz", "bgc", "bfc"];
            int exp = 1;
            int res = alg.MinDeletionSize(strs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test05()
        {
            string[] strs = ["vdy", "vei", "zvc", "zld"];
            int exp = 2;
            int res = alg.MinDeletionSize(strs);
            Assert.Equal(exp, res);
        }
    }
}
