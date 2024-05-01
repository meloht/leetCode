using leetCodeTemplates.≈≈–Ú;

namespace TemplateTest
{
    [TestClass]
    public class QuickSortUnitTest
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] nums = [ 12, 5, 9, 3, 2, 14, 10, 6 ];
            int[] exp = [2, 3, 5, 6, 9, 10, 12, 14];
            QuickSortAlg.QuickSort2(nums, 0, nums.Length - 1);
            Assert.IsTrue(exp.SequenceEqual(nums));
        }
    }
}