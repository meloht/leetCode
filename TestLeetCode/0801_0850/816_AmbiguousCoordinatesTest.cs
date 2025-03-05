using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _816_AmbiguousCoordinatesTest
    {
        _816_AmbiguousCoordinatesAlg alg = new _816_AmbiguousCoordinatesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "(123)";
            List<string> exp = ["(1, 23)", "(12, 3)", "(1.2, 3)", "(1, 2.3)"];
            var res = alg.AmbiguousCoordinates(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "(0123)";
            List<string> exp = ["(0, 123)", "(0, 12.3)", "(0, 1.23)", "(0.1, 23)", "(0.1, 2.3)", "(0.12, 3)"];
            var res = alg.AmbiguousCoordinates(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase03()
        {
            string s = "(100)";
            List<string> exp = ["(10, 0)"];
            var res = alg.AmbiguousCoordinates(s);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
