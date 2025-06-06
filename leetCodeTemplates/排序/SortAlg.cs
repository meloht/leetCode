﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.排序
{
    internal class SortAlg
    {

        // 归并排序算法
        public static void MergeSortAlgorithm(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                // 递归地排序左边的子数组
                MergeSortAlgorithm(array, left, middle);

                // 递归地排序右边的子数组
                MergeSortAlgorithm(array, middle + 1, right);

                // 合并两个子数组
                Merge(array, left, middle, right);
            }
        }

        // 合并两个子数组
        private static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // 复制左边剩余的元素
            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            // 复制右边剩余的元素
            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        // 桶排序算法
        public static void BucketSortAlgorithm(int[] array)
        {
            int n = array.Length;
            if (n <= 0)
                return;

            // 创建空桶
            List<int>[] buckets = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<int>();
            }

            // 将数组元素分配到各个桶中
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (int)(n * array[i]);
                buckets[bucketIndex].Add(array[i]);
            }

            // 对每个桶进行排序
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            // 合并所有桶中的数据
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    array[index++] = buckets[i][j];
                }
            }
        }

        // 基数排序算法
        public static void RadixSortAlgorithm(int[] array)
        {
            // 找到数组中最大的数以确定最大的位数
            int max = GetMax(array);

            // 从个位开始，对每一位进行计数排序
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(array, exp);
            }
        }

        // 获取数组中最大的数
        private static int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // 对数组进行计数排序
        private static void CountingSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n]; // 输出数组
            int[] count = new int[10]; // 计数数组，初始化为0

            // 计算每个数字出现的次数
            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            // 改变 count[i]，使其包含实际位置
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // 构建输出数组
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            // 将排序结果拷贝到原数组
            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        // 堆排序算法
        public static void HeapSortAlgorithm(int[] array)
        {
            int n = array.Length;

            // 构建最大堆
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // 一个一个地从堆中取出元素
            for (int i = n - 1; i > 0; i--)
            {
                // 将当前根节点与末尾节点交换
                Swap(array, 0, i);

                // 调整堆
                Heapify(array, i, 0);
            }
        }

        // 调整堆
        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // 初始化最大值为根节点
            int left = 2 * i + 1; // 左子节点
            int right = 2 * i + 2; // 右子节点

            // 如果左子节点比根节点大
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // 如果右子节点比当前最大值大
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // 如果最大值不是根节点
            if (largest != i)
            {
                Swap(array, i, largest);

                // 递归地调整受影响的子堆
                Heapify(array, n, largest);
            }
        }

        // 交换两个元素
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }



        public static void HeapSort(int[] array)
        {
            int n = array.Length;

            // 构建最大堆
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify1(array, n, i);
            }

            // 一个个从堆中取出元素
            for (int i = n - 1; i > 0; i--)
            {
                // 将堆顶元素（最大值）与当前未排序部分的最后一个元素交换
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // 重新调整堆，使其满足最大堆的性质
                Heapify1(array, i, 0);
            }
        }

        private static void Heapify1(int[] array, int n, int i)
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
