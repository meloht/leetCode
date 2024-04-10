using leetCode._0551_0600;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0551_0600
{
    [TestClass]
    public class _599_MinimumIndexSumOfTwoListsUnitTest
    {
        _599_MinimumIndexSumOfTwoListsAlg alg = new _599_MinimumIndexSumOfTwoListsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] list1 = ["Shogun", "Tapioca Express", "Burger King", "KFC"];
            string[] list2 = ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"];
            string[] exp = ["Shogun"];
            string[] res = alg.FindRestaurant(list1, list2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] list1 = ["Shogun", "Tapioca Express", "Burger King", "KFC"];
            string[] list2 = ["KFC", "Shogun", "Burger King"];
            string[] exp = ["Shogun"];
            string[] res = alg.FindRestaurant(list1, list2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] list1 = ["sad", "happy", "good"];
            string[] list2 = ["happy", "sad", "good"];
            string[] exp = ["sad", "happy"];
            string[] res = alg.FindRestaurant(list1, list2);
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }

}
