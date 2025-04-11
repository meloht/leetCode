using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _912_SortAnArrayAlg
    {
        public int[] SortArray(int[] nums)
        {
        
            return nums;
        }





        public static void HeapSort(int[] array)
        {
            int n = array.Length;

            // 构建最大堆
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // 一个个从堆中取出元素
            for (int i = n - 1; i > 0; i--)
            {
                // 将堆顶元素（最大值）与当前未排序部分的最后一个元素交换
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // 重新调整堆，使其满足最大堆的性质
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // 初始化根节点为最大值
            int left = 2 * i + 1; // 左子节点
            int right = 2 * i + 2; // 右子节点

            // 如果左子节点大于根节点
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // 如果右子节点大于当前最大值
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // 如果最大值不是根节点
            if (largest != i)
            {
                // 交换根节点和最大值节点
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // 递归调整受影响的子树
                Heapify(array, n, largest);
            }
        }



        private static readonly Random _random = new Random();

        public static void QuickSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        // 随机化分区函数
        private static int Partition(int[] arr, int low, int high)
        {
            // 随机选择基准并交换到末尾
            int randomIndex = _random.Next(low, high + 1); // 包含high
            Swap(arr, randomIndex, high);

            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            if (i == j) return; // 相同索引无需交换
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }



        public static void mergeSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
            {
                return;
            }
            int[] temp = new int[arr.Length];
            mergeSort(arr, 0, arr.Length - 1, temp);
        }

        private static void mergeSort(int[] arr, int left, int right, int[] temp)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                // 递归排序左半部分
                mergeSort(arr, left, mid, temp);
                // 递归排序右半部分
                mergeSort(arr, mid + 1, right, temp);
                // 合并两个有序的子数组
                merge(arr, left, mid, right, temp);
            }
        }

        private static void merge(int[] arr, int left, int mid, int right, int[] temp)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[t++] = arr[i++];
                }
                else
                {
                    temp[t++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                temp[t++] = arr[i++];
            }
            while (j <= right)
            {
                temp[t++] = arr[j++];
            }
            t = 0;
            while (left <= right)
            {
                arr[left++] = temp[t++];
            }
        }
    }
}
