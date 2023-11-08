// Вариант 12
using System;

class Program
{
    static double Fibbonaci(int n)
    {
        if (n <= 1)
            return n;

        double a = 0;
        double b = 1;
        double temp;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }

    static double FindLimit(double precision)
    {
        int n = 1;
        double prevRatio = 0;
        double currentRatio = 0;
        double goldenRatio = 0.5 * (1 + Math.Sqrt(5)); // Золотое сечение

        do
        {
            prevRatio = currentRatio;
            currentRatio = Fibbonaci(n) / Fibbonaci(n - 1);
            n++;
        }
        while (Math.Abs(currentRatio - prevRatio) > precision);

        return currentRatio;
    }

    public static void Zad2()
    {
        double x = 0.5; // Измените значение x на нужное вам
        double sum = 0;
        double term = x;
        int n = 1;

        while (Math.Abs(term) > 1e-6)
        {
            sum += term;
            term *= -(x * x) / ((2 * n) * (2 * n + 1)); // Вычисление следующего члена ряда
            n++;
        }

        double y = Math.Log((1 + x) / (1 - x)); // Вычисление y(x) с помощью функции Math.Log

        Console.WriteLine("Задание 2");
        Console.WriteLine($"Значение функции y(x) для x = {x}: {y}");
        Console.WriteLine($"Приближенное значение функции y(x) суммой ряда: {sum}");
    }

    static void Main()
    {
        double precision1 = 0.01;
        double precision2 = 0.001;
        double precision3 = 0.0001;

        double limit1 = FindLimit(precision1);
        double limit2 = FindLimit(precision2);
        double limit3 = FindLimit(precision3);

        Console.WriteLine("Задание 1");
        Console.WriteLine("Предел с точностью 0.01: " + limit1);
        Console.WriteLine("Предел с точностью 0.001: " + limit2);
        Console.WriteLine("Предел с точностью 0.0001: " + limit3);
        Zad2();
    }
}
