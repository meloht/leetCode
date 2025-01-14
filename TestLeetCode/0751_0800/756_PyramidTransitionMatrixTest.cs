using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _756_PyramidTransitionMatrixTest
    {
        _756_PyramidTransitionMatrixAlg alg = new _756_PyramidTransitionMatrixAlg();

        [TestMethod]
        public void TestCase01()
        {
            string bottom = "BCD";
            string[] allowed = ["BCC", "CDE", "CEA", "FFF"];
            bool exp = true;
            bool res = alg.PyramidTransition(bottom, allowed);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string bottom = "AAAA";
            string[] allowed = ["AAB", "AAC", "BCD", "BBE", "DEF"];
            bool exp = false;
            bool res = alg.PyramidTransition(bottom, allowed);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string bottom = "BDBBAA";
            string[] allowed = ["ACB", "ACA", "AAA", "ACD", "BCD", "BAA", "BCB", "BCC", "BAD", "BAB", "BAC", "CAB", "CCD", "CAA", "CCA", "CCC", "CAD", "DAD", "DAA", "DAC", "DCD", "DCC", "DCA", "DDD", "BDD", "ABB", "ABC", "ABD", "BDB", "BBD", "BBC", "BBA", "ADD", "ADC", "ADA", "DDC", "DDB", "DDA", "CDA", "CDD", "CBA", "CDB", "CBD", "DBA", "DBC", "DBD", "BDA"];
            bool exp = true;
            bool res = alg.PyramidTransition(bottom, allowed);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string bottom = "CB";
            string[] allowed = ["CDD", "CBC", "ACA", "BDD", "ADD", "DCA", "BAD", "ADA"];
            bool exp = true;
            bool res = alg.PyramidTransition(bottom, allowed);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            string bottom = "DAAAAD";
            string[] allowed = ["DAD", "DAE", "DAB", "DAF", "DAC", "EAD", "EAE", "EAB", "EAF", "EAC", "BAD", "BAE", "BAB", "BAF", "BAC", "FAD", "FAE", "FAB", "FAF", "FAC", "CAD", "CAE", "CAB", "CAF", "CAC", "ADD", "ADE", "ADB", "ADF", "ADC", "AED", "AEE", "AEB", "AEF", "AEC", "ABD", "ABE", "ABB", "ABF", "ABC", "AFD", "AFE", "AFB", "AFF", "AFC", "ACD", "ACE", "ACB", "ACF", "ACC", "AAD", "AAE", "AAB", "AAF", "AAC", "AAA"];
            bool exp = false;
            bool res = alg.PyramidTransition(bottom, allowed);
            Assert.AreEqual(exp, res);
        }
    }
}
