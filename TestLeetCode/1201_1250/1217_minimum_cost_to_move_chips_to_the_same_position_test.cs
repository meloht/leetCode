using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1201_1250
{
    [TestClass]
    public class _1217_minimum_cost_to_move_chips_to_the_same_position_test
    {
        _1217_minimum_cost_to_move_chips_to_the_same_position alg = new _1217_minimum_cost_to_move_chips_to_the_same_position();

        [TestMethod]
        public void TestCase01()
        {
            int[] position = [1, 2, 3];
            int exp = 1;
            int res = alg.MinCostToMoveChips(position);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] position = [2, 2, 2, 3, 3];
            int exp = 2;
            int res = alg.MinCostToMoveChips(position);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] position = [1, 1000000000];
            int exp = 1;
            int res = alg.MinCostToMoveChips(position);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] position = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
            int exp = 15;
            int res = alg.MinCostToMoveChips(position);
            Assert.AreEqual(exp, res);
        }
    }
}
