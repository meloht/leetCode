using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1251_1300
{
    [TestClass]
    public class _1282_group_the_people_given_the_group_size_they_belong_to_test
    {
        _1282_group_the_people_given_the_group_size_they_belong_to alg = new _1282_group_the_people_given_the_group_size_they_belong_to();

        [TestMethod]
        public void Test01()
        {
            int[] groupSizes = [3, 3, 3, 3, 3, 1, 3];
            IList<IList<int>> exp = [[0, 1, 2], [3, 4, 6], [5]];
            var res = alg.GroupThePeople(groupSizes);
            Assert.IsTrue(Utils.IsSame(exp,res));
        }

        [TestMethod]
        public void Test02()
        {
            int[] groupSizes = [2, 1, 3, 3, 3, 2];
            IList<IList<int>> exp = [[0, 5], [1], [2, 3, 4]];
            var res = alg.GroupThePeople(groupSizes);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
    }
}
