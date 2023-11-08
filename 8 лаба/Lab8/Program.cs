using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Генерация, сортировка и поиск в массиве
        int[] arr = GenerateAndSortArray(10002);
        Console.Write("Введите целое число для поиска: ");
        if (int.TryParse(Console.ReadLine(), out int searchNumber))
        {
            int position = InterpolationSearch(arr, searchNumber);
            if (position != -1)
                Console.WriteLine($"Число {searchNumber} найдено на позиции {position}.");
            else
                Console.WriteLine($"Число {searchNumber} не найдено в массиве.");
        }
        else
        {
            Console.WriteLine("Введено некорректное число.");
        }

        // Задание 2: Поиск слова в текстовом файле
        Console.Write("Введите слово для поиска в текстовом файле: ");
        string wordToSearch = Console.ReadLine();
        FindWordInFile("text.txt", wordToSearch);

        // Задание 3: Создание файл-глоссария
        CreateGlossaryFile("text.txt", "glossary.txt");
    }

    // Задание 1: Генерация, сортировка и поиск в массиве
    static int[] GenerateAndSortArray(int n)
    {
        Random random = new Random();
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(1, 10000);
        }

        Array.Sort(arr);
        return arr;
    }

    static int InterpolationSearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right && target >= arr[left] && target <= arr[right])
        {
            int pos = left + ((target - arr[left]) * (right - left)) / (arr[right] - arr[left]);

            if (arr[pos] == target)
                return pos;

            if (arr[pos] < target)
                left = pos + 1;
            else
                right = pos - 1;
        }

        return -1;
    }

    // Задание 2: Поиск слова в текстовом файле
    static void FindWordInFile(string filePath, string wordToSearch)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            var positions = lines.Select((line, index) => new { Line = line, Index = index + 1 })
                                .Where(x => x.Line.Contains(wordToSearch))
                                .Select(x => x.Index);

            Console.WriteLine($"Слово '{wordToSearch}' найдено в следующих строках: {string.Join(", ", positions)}");
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }

    // Задание 3: Создание файл-глоссария
    static void CreateGlossaryFile(string sourceFilePath, string glossaryFilePath)
    {
        if (File.Exists(sourceFilePath))
        {
            string[] lines = File.ReadAllLines(sourceFilePath);
            var glossary = lines.SelectMany((line, index) => line.Split(' ')
                .Select(word => new { Word = word, Index = index + 1 }))
                .GroupBy(x => x.Word, x => x.Index)
                .ToDictionary(g => g.Key, g => string.Join(", ", g));

            using (StreamWriter writer = new StreamWriter(glossaryFilePath))
            {
                foreach (var entry in glossary)
                {
                    writer.WriteLine($"{entry.Key} | {entry.Value}");
                }
            }

            Console.WriteLine($"Файл-глоссарий успешно создан: {glossaryFilePath}");
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}
