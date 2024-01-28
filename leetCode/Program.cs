using leetCode._0151_0200;
using leetCode._1_50;
using leetCode._51_100;
using leetCode.WeeklyContest;

namespace leetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int r = 9; // 选择的元素个数
            //int n = numbers.Length;

            //GenerateCombinations(numbers, n, r);

            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            // Enqueue some elements
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(4);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(9);

            // Dequeue elements (they will be in ascending order due to the min heap)
            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        // 生成组合
        static void GenerateCombinations(int[] arr, int n, int r)
        {
            int totalCombinations = Factorial(n) / (Factorial(r) * Factorial(n - r));
            Console.WriteLine($"总共有 {totalCombinations} 种组合：");

            int[] data = new int[r];
            GenerateCombinationsUtil(arr, data, 0, n - 1, 0, r);
        }

        static void GenerateCombinationsUtil(int[] arr, int[] data, int start, int end, int index, int r)
        {
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(data[j] + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                GenerateCombinationsUtil(arr, data, i + 1, end, index + 1, r);
            }
        }


        class PriorityQueue<T> where T : IComparable<T>
        {
            private List<T> heap;

            public PriorityQueue()
            {
                heap = new List<T>();
            }

            public int Count
            {
                get { return heap.Count; }
            }

            public void Enqueue(T item)
            {
                heap.Add(item);
                HeapifyUp(heap.Count - 1);
            }

            public T Dequeue()
            {
                if (heap.Count == 0)
                    throw new InvalidOperationException("Queue is empty");

                T root = heap[0];
                heap[0] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);

                if (heap.Count > 1)
                    HeapifyDown(0);

                return root;
            }

            private void HeapifyUp(int index)
            {
                while (index > 0)
                {
                    int parent = (index - 1) / 2;

                    if (heap[index].CompareTo(heap[parent]) < 0)
                    {
                        Swap(index, parent);
                        index = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            private void HeapifyDown(int index)
            {
                int leftChild, rightChild, smallest;

                while (true)
                {
                    leftChild = 2 * index + 1;
                    rightChild = 2 * index + 2;
                    smallest = index;

                    if (leftChild < heap.Count && heap[leftChild].CompareTo(heap[smallest]) < 0)
                        smallest = leftChild;

                    if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[smallest]) < 0)
                        smallest = rightChild;

                    if (smallest != index)
                    {
                        Swap(index, smallest);
                        index = smallest;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            private void Swap(int i, int j)
            {
                T temp = heap[i];
                heap[i] = heap[j];
                heap[j] = temp;
            }
        }
    }
}