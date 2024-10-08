using leetCode._1401_1450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1401_1450
{
    [TestClass]
    public class _1436_DestinationCityTest
    {
        _1436_DestinationCityAlg alg = new _1436_DestinationCityAlg();
        [TestMethod]
        public void TestCase01()
        {
            string[][] paths = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];
            string exp = "Sao Paulo";
            string res = alg.DestCity(paths);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[][] paths = [["B", "C"], ["D", "B"], ["C", "A"]];
            string exp = "A";
            string res = alg.DestCity(paths);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[][] paths = [["A", "Z"]];
            string exp = "Z";
            string res = alg.DestCity(paths);
            Assert.AreEqual(exp, res);
        }
    }
}
