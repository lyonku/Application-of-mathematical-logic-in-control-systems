using System;

class Program
{
    static void TransposeMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                // Обмен значений элементов матрицы
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Введите размерность квадратной матрицы: ");
        int size = int.Parse(Console.ReadLine());

        if (size > 0 && size <= 100)
        {
            int[,] matrix = new int[size, size];

            Console.WriteLine("Введите элементы матрицы (построково):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix, size);

            TransposeMatrix(matrix, size);

            Console.WriteLine("Транспонированная матрица:");
            PrintMatrix(matrix, size);
        }
        else
        {
            Console.WriteLine("Некорректная размерность матрицы. Размерность должна быть в диапазоне от 1 до 100.");
        }
    }
}
