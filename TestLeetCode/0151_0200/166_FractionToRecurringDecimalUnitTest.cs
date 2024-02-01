using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _166_FractionToRecurringDecimalUnitTest
    {
        _166_FractionToRecurringDecimalAlg alg = new _166_FractionToRecurringDecimalAlg();


        [TestMethod]
        public void TestCase01()
        {
            int numerator = 1, denominator = 2;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.5", res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int numerator = 2, denominator = 1;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("2", res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int numerator = 4, denominator = 333;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(012)", res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int numerator = 3, denominator = 39;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(076923)", res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int numerator = 4, denominator = 9;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(4)", res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int numerator = 1, denominator = 6;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.1(6)", res);
        }

        [TestMethod]
        public void TestCase07()
        {
            int numerator = 1, denominator = 333;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(003)", res);
        }

        [TestMethod]
        public void TestCase08()
        {
            int numerator = 1, denominator = 17;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(0588235294117647)", res);
        }

        [TestMethod]
        public void TestCase09()
        {
            int numerator = 1, denominator = 19;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.(052631578947368421)", res);
        }
        [TestMethod]
        public void TestCase10()
        {
            int numerator = -50, denominator = 8;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("-6.25", res);
        }

        [TestMethod]
        public void TestCase11()
        {
            int numerator = 7, denominator = -12;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("-0.58(3)", res);
        }

        [TestMethod]
        public void TestCase12()
        {
            int numerator = 1, denominator = 214748364;
            var res = alg.FractionToDecimal(numerator, denominator);
            Assert.AreEqual("0.00(000000465661289042462740251655654056577585848337359161441621040707904997124914069194026549138227660723878669455195477065427143370461252966751355553982241280310754777158628319049732085502639731402098131932683780538602845887105337854867197032523144157689601770377165713821223802198558308923834223016478952081795603341592860749337303449725)", res);
        }

        [TestMethod]
        public void TestCase13()
        {
            int numerator = -1, denominator = -2147483648;
            var res = alg.FractionToDecimal(numerator, denominator);
            
        }
    }
}
