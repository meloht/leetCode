using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCodeTemplates.排序
{
    public class QuickSortAlg
    {
        public static void QuickSort(int[] nums, int left, int right)
        {
            if (left >= right)
                return;

            int mid = nums[left];
            int low = left;
            int high = right;
            while (low < high)
            {
                while (low < high && nums[high] >= mid)
                {
                    high--;
                }
                nums[low] = nums[high];
                while (low < high && nums[low] < mid)
                {
                    low++;
                }
                nums[high] = nums[low];

            }
            nums[low] = mid;
            QuickSort(nums, left, low - 1);
            QuickSort(nums, low + 1, right);
        }
        static Random random = new Random();
        public static void QuickSort2(int[] nums, int left, int right)
        {
            if (left >= right)
                return;

            // 随机选择基准元素并将其交换到数组的第一个位置
            int randomIndex = random.Next(left, right + 1);
            Swap(nums, left, randomIndex);

            // 初始化三个指针
            int lt = left; // 指向小于基准元素的部分的最后一个元素
            int gt = right; // 指向大于基准元素的部分的第一个元素
            int i = left + 1; // 当前处理的元素

            int pivot = nums[left]; // 基准元素

            while (i <= gt)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums, i, lt); // 将小于基准元素的部分的最后一个元素和当前元素交换
                    lt++;
                    i++;
                }
                else if (nums[i] > pivot)
                {
                    Swap(nums, i, gt); // 将大于基准元素的部分的第一个元素和当前元素交换
                    gt--;
                }
                else
                {
                    i++; // 相等时只移动当前处理的元素指针
                }
            }

            // 递归对小于和大于基准元素的部分进行排序
            Sort(nums, left, lt - 1);
            Sort(nums, gt + 1, right);
        }


        // 快速排序函数
        public static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // 获取划分点
                int pivotIndex = Partition(array, left, right);

                // 对划分点左侧子数组进行快速排序
                Sort(array, left, pivotIndex - 1);

                // 对划分点右侧子数组进行快速排序
                Sort(array, pivotIndex + 1, right);
            }
        }

        // 划分函数
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right]; // 将数组最后一个元素作为基准元素
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                // 如果当前元素小于等于基准元素，则将其与 i 指向的元素交换位置
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            // 将基准元素放到正确的位置上
            Swap(array, i + 1, right);
            return i + 1;
        }

        // 随机划分函数
        public static int RandomPartition(int[] array, int left, int right)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(left, right + 1); // 生成 left 到 right 之间的随机索引
            Swap(array, randomIndex, right); // 将随机选择的元素与最后一个元素交换位置

            return Partition(array, left, right);
        }

        // 交换数组中两个元素的位置
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
