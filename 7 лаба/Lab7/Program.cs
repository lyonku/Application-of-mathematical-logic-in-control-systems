using System;
using System.Diagnostics;

class SortingProgram
{
    public static void Main(string[] args)
    {
        int[] intArray = { 5, 2, 9, 1, 5, 6 };
        string[] stringArray = { "banana", "apple", "cherry", "date", "grape" };

        Console.WriteLine("Выберите тип элементов (1 - целые, 2 - строки):");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Исходный массив целых чисел: ");
            PrintArray(intArray);

            // Вызов различных методов сортировки для массива целых чисел
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            BubbleSort(intArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка обменами: ");
            PrintArray(intArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            intArray = new int[] { 5, 2, 9, 1, 5, 6 }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            SelectionSort(intArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка выбором: ");
            PrintArray(intArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            intArray = new int[] { 5, 2, 9, 1, 5, 6 }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            InsertionSort(intArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка включением: ");
            PrintArray(intArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            intArray = new int[] { 5, 2, 9, 1, 5, 6 }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            QuickSort(intArray, 0, intArray.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Быстрая сортировка: ");
            PrintArray(intArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Исходный массив строк: ");
            PrintArray(stringArray);

            // Вызов различных методов сортировки для массива строк
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            BubbleSort(stringArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка обменами: ");
            PrintArray(stringArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            stringArray = new string[] { "banana", "apple", "cherry", "date", "grape" }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            SelectionSort(stringArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка выбором: ");
            PrintArray(stringArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            stringArray = new string[] { "banana", "apple", "cherry", "date", "grape" }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            InsertionSort(stringArray);
            stopwatch.Stop();
            Console.WriteLine("Сортировка включением: ");
            PrintArray(stringArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");

            stringArray = new string[] { "banana", "apple", "cherry", "date", "grape" }; // Восстановление исходного массива

            stopwatch.Reset();
            stopwatch.Start();
            QuickSort(stringArray, 0, stringArray.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Быстрая сортировка: ");
            PrintArray(stringArray);
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
        else
        {
            Console.WriteLine("Неправильный выбор.");
        }
    }

    // Метод для сортировки обменами (Bubble Sort)
    public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Метод для сортировки выбором (Selection Sort)
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j].CompareTo(arr[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                T temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    // Метод для сортировки включением (Insertion Sort)
    public static void InsertionSort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            T key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j].CompareTo(key) > 0)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    // Метод для быстрой сортировки (Quick Sort)
    public static void QuickSort<T>(T[] arr, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);
            QuickSort(arr, low, partitionIndex - 1);
            QuickSort(arr, partitionIndex + 1, high);
        }
    }

    private static int Partition<T>(T[] arr, int low, int high) where T : IComparable<T>
    {
        T pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j].CompareTo(pivot) < 0)
            {
                i++;
                T temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        T swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }

    // Метод для вывода массива на экран
    public static void PrintArray<T>(T[] arr)
    {
        foreach (T item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
