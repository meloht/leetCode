using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1251_1300
{
    [TestClass]
    public class _1276_number_of_burgers_with_no_waste_of_ingredients_test
    {
        _1276_number_of_burgers_with_no_waste_of_ingredients alg = new _1276_number_of_burgers_with_no_waste_of_ingredients();


        [TestMethod]
        public void Test01()
        {
            int tomatoSlices = 16, cheeseSlices = 7;
            IList<int> exp = [1, 6];
            IList<int> res = alg.NumOfBurgers(tomatoSlices, cheeseSlices);
            Assert.AreSequenceEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int tomatoSlices = 17, cheeseSlices = 4;
            IList<int> exp = [];
            IList<int> res = alg.NumOfBurgers(tomatoSlices, cheeseSlices);
            Assert.AreSequenceEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int tomatoSlices = 4, cheeseSlices = 17;
            IList<int> exp = [];
            IList<int> res = alg.NumOfBurgers(tomatoSlices, cheeseSlices);
            Assert.AreSequenceEqual(exp, res);
        }

        [TestMethod]
        public void Test04()
        {
            int tomatoSlices = 0, cheeseSlices = 0;
            IList<int> exp = [0, 0];
            IList<int> res = alg.NumOfBurgers(tomatoSlices, cheeseSlices);
            Assert.AreSequenceEqual(exp, res);
        }

        [TestMethod]
        public void Test05()
        {
            int tomatoSlices = 2, cheeseSlices = 1;
            IList<int> exp = [0, 1];
            IList<int> res = alg.NumOfBurgers(tomatoSlices, cheeseSlices);
            Assert.AreSequenceEqual(exp, res);
        }
    }
}
