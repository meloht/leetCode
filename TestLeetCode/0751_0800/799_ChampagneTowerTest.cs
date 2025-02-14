using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _799_ChampagneTowerTest
    {
        _799_ChampagneTowerAlg alg = new _799_ChampagneTowerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int poured = 1;
            int query_row = 1;
            int query_glass = 1;
            double exp = 0;
            var res = alg.ChampagneTower(poured, query_row, query_glass);
            Assert.IsTrue(exp == res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int poured = 2;
            int query_row = 1;
            int query_glass = 1;
            double exp = 0.5;
            var res = alg.ChampagneTower(poured, query_row, query_glass);
            Assert.IsTrue(exp == res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int poured = 100000009;
            int query_row = 33;
            int query_glass = 17;
            double exp = 1.0;
            var res = alg.ChampagneTower(poured, query_row, query_glass);
            Assert.IsTrue(exp == res);
        }
    }
}
