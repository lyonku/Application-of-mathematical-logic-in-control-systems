// Вариант 12
using System;

class Program
{
    static void Main()
    {
        double Zad;
        Console.Write("Впишите номер задания (1 или 2): ");
        Zad = Convert.ToDouble(Console.ReadLine());
        if (Zad == 1)
        {
            Zad1();
        }
        else
        {
            Zad2();
        }

    }

    // Задание 1
    // Разработайте программу, которая вычисляется периметр правильного пятиугольника. Значение длины стороны вводится с клавиатуры
    public static void Zad1()
    {
        double sideLength;

        Console.Write("Введите длину стороны пятиугольника: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
        if (sideLength > 0)
        {
            double perimeter = 5 * sideLength; // Формула для периметра правильного пятиугольника
            Console.WriteLine("Периметр пятиугольника: " + perimeter);
        }
        else
        {
            Console.WriteLine("Длина стороны должна быть положительным числом.");
        }
    }

    // Задание 2
    // Определить для своего варианта номер N области, в которой находится точка M(x, y) с заданными 
    // координатами. Границы обласьт относить к области с наибюольшим номером
    public static void Zad2()
    {
        double x, y;
        int N = 0;

        Console.Write("Введите x: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: ");
        y = Convert.ToDouble(Console.ReadLine());

        if (y >= x && y <= x + 1)
            N = 1;
        else if (y > x + 1)
            N = 3;
        else if (x >= 0 && y < x)
            N = 4;
        else
            N = 2;

        Console.WriteLine("Точка M лежит на области N = " + N);
    }
}