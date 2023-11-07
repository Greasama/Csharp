using System;
using static System.Console;
//在C#使用的Array.Sort算法排序为该方法使用内省排序（introsort）算法，具体如下：
//如果分区大小小于或等于 16 个元素，则使用 InsertionSort 算法。
//如果分区数超过 2 * LogN（其中 N 是输入数组的范围），则使用 Heapsort 算法。
//否则，将使用 Quicksort 算法。
class BubbleSort//冒泡排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }//随机输入一个数组
        WriteLine("排序前的数组：");
        Printarr(arr);
        BubbleSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // 交换 arr[j] 和 arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            // 如果在一轮比较中没有发生交换，则数组已经有序，可以提前结束排序
            if (!swapped)
                break;
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class SelectionSort//选择排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        SelectionSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                // 交换 arr[i] 和 arr[minIndex]
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class InsertionSort//插入排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        InsertionSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class ShellSort//希尔排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        SelectionSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class MergeSort//归并排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        MergeSortAlgorithm(arr, 0, n - 1);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void MergeSortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortAlgorithm(arr, left, mid);
            MergeSortAlgorithm(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];
        Array.Copy(arr, left, leftArray, 0, n1);
        Array.Copy(arr, mid + 1, rightArray, 0, n2);
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k] = leftArray[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class QuickSort//快速排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        SelectionSortAlgorithm(arr, 0, n - 1);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void SelectionSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            SelectionSortAlgorithm(arr, low, pivotIndex - 1);
            SelectionSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i + 1;
    }
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class HeapSort//堆排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        HeapSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void HeapSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        // 构建最大堆
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        // 从堆中一个个取出元素并排序
        for (int i = n - 1; i >= 0; i--)
        {
            // 将当前根节点（最大元素）与数组末尾的元素交换
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // 调整堆，排除已排序部分
            Heapify(arr, i, 0);
        }
    }
    static void Heapify(int[] arr, int n, int root)
    {
        int largest = root;
        int leftChild = 2 * root + 1;
        int rightChild = 2 * root + 2;
        // 找到左子节点比根节点大的情况
        if (leftChild < n && arr[leftChild] > arr[largest])
        {
            largest = leftChild;
        }
        // 找到右子节点比根节点大的情况
        if (rightChild < n && arr[rightChild] > arr[largest])
        {
            largest = rightChild;
        }
        // 如果最大值不是根节点，交换它们并继续堆化
        if (largest != root)
        {
            int swap = arr[root];
            arr[root] = arr[largest];
            arr[largest] = swap;
            // 递归调用，继续对子树进行堆化
            Heapify(arr, n, largest);
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class CountingSort//计数排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        CountingSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void CountingSortAlgorithm(int[] arr)
    {
        // 寻找数组中的最大值和最小值
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        // 计算计数数组的范围
        int range = max - min + 1;
        // 创建计数数组
        int[] count = new int[range];
        // 统计每个元素出现的次数
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i] - min]++;
        }
        // 将计数数组转换为累积计数数组
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        // 创建临时数组存储排序结果
        int[] result = new int[arr.Length];
        // 根据累积计数数组将元素放入正确的位置
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            result[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }
        // 将排序结果复制回原始数组
        Array.Copy(result, arr, arr.Length);
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class BucketSort//桶排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        BucketSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }
    static void BucketSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        // 找到最大值和最小值
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        // 计算桶的数量
        int bucketCount = (max - min) / n + 1;
        // 创建桶
        List<int>[] buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }
        // 将元素放入对应的桶中
        for (int i = 0; i < n; i++)
        {
            int bucketIndex = (arr[i] - min) / n;
            buckets[bucketIndex].Add(arr[i]);
        }
        // 对每个桶内部进行排序
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i].Sort();
        }
        // 将桶中的元素按顺序放回原数组
        int index = 0;
        for (int i = 0; i < bucketCount; i++)
        {
            foreach (var num in buckets[i])
            {
                arr[index++] = num;
            }
        }
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}

class RadixSort//基数排序
{
    static void Main()
    {
        Write("请输入数组元素个数：");
        int n = int.Parse(ReadLine());
        int[] arr = new int[n];
        WriteLine("请输入数组元素（每个元素用空格或回车隔开）：");
        string[] inputElements = ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputElements[i]);
        }
        WriteLine("\n排序前的数组：");
        Printarr(arr);
        RadixSortAlgorithm(arr);
        WriteLine("\n排序后的数组：");
        Printarr(arr);
    }

    static void RadixSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        int max = GetMax(arr);
        // 进行基数排序，从个位数开始到最高位
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(arr, n, exp);
        }
    }
    static void CountSort(int[] arr, int n, int exp)
    {
        int[] output = new int[n];
        int[] count = new int[10]; 
        // 0 到 9 十个数字的计数数组
        // 初始化计数数组
        for (int i = 0; i < 10; i++)
        {
            count[i] = 0;
        }
        // 统计每个数字出现的次数
        for (int i = 0; i < n; i++)
        {
            count[(arr[i] / exp) % 10]++;
        }
        // 将计数数组转换为累积计数数组
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }
        // 从原始数组中构建排序后的数组
        for (int i = n - 1; i >= 0; i--)
        {
            output[count[(arr[i] / exp) % 10] - 1] = arr[i];
            count[(arr[i] / exp) % 10]--;
        }
        // 将排序后的数组复制回原始数组
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (var num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
    static void Printarr(int[] arr)
    {
        foreach (var item in arr)
        {
            Write(item + " ");
        }
        WriteLine();
    }
}
