using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _412_FizzBuzzUnitTest
    {
        _412_FizzBuzzAlg alg = new _412_FizzBuzzAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            string[] exp = ["1", "2", "Fizz"];
            string[] res = alg.FizzBuzz(n).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 5;
            string[] exp = ["1", "2", "Fizz", "4", "Buzz"];
            string[] res = alg.FizzBuzz(n).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase03()
        {
            int n = 15;
            string[] exp = ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"];
            string[] res = alg.FizzBuzz(n).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
