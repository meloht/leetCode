using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _922_SortArrayByParityIIUnitTest
    {
        _922_SortArrayByParityIIAlg alg = new _922_SortArrayByParityIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 2, 5, 7];
          
            int[] res = alg.SortArrayByParityII(nums);
            bool bl = true;
            for (int i = 0; i < res.Length; i++)
            {
                if (i % 2 == 0 && res[i] % 2 == 1)
                {
                    bl = false;
                    break;
                }
                if (i % 2 == 1 && res[i] % 2 == 0)
                {
                    bl = false;
                    break;
                }
            }
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 3];
            int[] exp = [2, 3];
            int[] res = alg.SortArrayByParityII(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 0, 4];
           
            int[] res = alg.SortArrayByParityII(nums);
            bool bl = true;
            for (int i = 0; i < res.Length; i++)
            {
                if (i % 2 == 0 && res[i] % 2 == 1)
                {
                    bl = false;
                    break;
                }
                if (i % 2 == 1 && res[i] % 2 == 0)
                {
                    bl = false;
                    break;
                }
            }
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [888, 505, 627, 846];
           
            int[] res = alg.SortArrayByParityII(nums);

            bool bl = true;
            for (int i = 0; i < res.Length; i++)
            {
                if (i % 2 == 0 && res[i] % 2 == 1)
                {
                    bl = false;
                    break;
                }
                if (i % 2 == 1 && res[i] % 2 == 0)
                {
                    bl = false;
                    break;
                }
            }
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [2, 1, 0, 1, 1, 2, 0, 3];

            int[] res = alg.SortArrayByParityII(nums);

            bool bl = true;
            for (int i = 0; i < res.Length; i++)
            {
                if (i % 2 == 0 && res[i] % 2 == 1)
                {
                    bl = false;
                    break;
                }
                if (i % 2 == 1 && res[i] % 2 == 0)
                {
                    bl = false;
                    break;
                }
            }
            Assert.IsTrue(bl);
        }
    }
}
