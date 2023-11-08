using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Вычислить произведение элементов одномерного массива
        int[] array = { 2, 3, 4, 5 };
        int product = CalculateProduct(array);
        Console.WriteLine($"Произведение элементов массива: {product}");

        // Задание 2: Рекурсивный факториал
        int n = 5;
        long factorial = CalculateFactorial(n);
        Console.WriteLine($"{n}! = {factorial}");

        // Задание 3: Рекурсивная последовательность Фибоначчи
        int fiboTerm = 10;
        for (int i = 0; i < fiboTerm; i++)
        {
            Console.Write(CalculateFibonacci(i) + " ");
        }
        Console.WriteLine();

        // Задание 4: Решение головоломки "Ханойская башня"
        int numDisks = 3;
        SolveHanoiTower(numDisks, 'A', 'C', 'B');
    }

    // Задание 1: Вычислить произведение элементов одномерного массива
    static int CalculateProduct(int[] array)
    {
        int product = 1;
        foreach (int element in array)
        {
            product *= element;
        }
        return product;
    }

    // Задание 2: Рекурсивный факториал
    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        return n * CalculateFactorial(n - 1);
    }

    // Задание 3: Рекурсивная последовательность Фибоначчи
    static int CalculateFibonacci(int n)
    {
        if (n <= 1)
            return n;
        return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    }

    // Задание 4: Решение головоломки "Ханойская башня"
    static void SolveHanoiTower(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"{source} {destination}");
            return;
        }

        SolveHanoiTower(n - 1, source, auxiliary, destination);
        Console.WriteLine($"{source} {destination}");
        SolveHanoiTower(n - 1, auxiliary, destination, source);
    }
}
