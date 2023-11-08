using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        Random random = new Random();

        // Заполняем очередь 8 случайными числами из интервала [20; 70]
        for (int i = 0; i < 8; i++)
        {
            int randomValue = random.Next(20, 71);
            queue.Enqueue(randomValue);
        }

        // Выводим исходную очередь
        Console.WriteLine("Исходная очередь: " + string.Join(", ", queue));

        // Вычисляем среднее арифметическое 2-го и 4-го чисел очереди
        if (queue.Count >= 4)
        {
            int secondElement = queue.ElementAt(1);
            int fourthElement = queue.ElementAt(3);
            double average = (secondElement + fourthElement) / 2.0;
            Console.WriteLine("Среднее арифметическое 2-го и 4-го чисел: " + average);
        }
        else
        {
            Console.WriteLine("Недостаточно элементов в очереди для вычисления среднего.");
        }

        // Сортировка вставкой
        InsertionSort(queue);

        // Выводим отсортированную очередь
        Console.WriteLine("Отсортированная очередь: " + string.Join(", ", queue));
    }

    static void InsertionSort(Queue<int> queue)
    {
        int[] array = queue.ToArray();
        for (int i = 1; i < array.Length; i++)
        {
            int current = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
        queue.Clear();
        foreach (int item in array)
        {
            queue.Enqueue(item);
        }
    }
}
