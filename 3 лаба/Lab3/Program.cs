using System;
// Вариант 12
// Написать программу для поиска в заданном массиве B? состоящем из 10-ти элементов, третьего 
// положительного элемента и его индекса. Известно что хотя бы один положительный элемент в 
// массиве B имеется

class Program
{
    static void Main()
    {
        int[] B = new int[10] { -2, 5, 1, -7, 3, 0, 9, 4, -1, 6 };

        int positiveCount = 0;
        int thirdPositiveIndex = -1;

        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] > 0)
            {
                positiveCount++;
                if (positiveCount == 3)
                {
                    thirdPositiveIndex = i;
                    break;
                }
            }
        }

        if (thirdPositiveIndex != -1)
        {
            Console.WriteLine($"Третий положительный элемент в массиве B равен {B[thirdPositiveIndex]}.");
            Console.WriteLine($"Индекс третьего положительного элемента в массиве B: {thirdPositiveIndex}");
        }
        else
        {
            Console.WriteLine("В массиве B не найдено третьего положительного элемента.");
        }
    }
}
