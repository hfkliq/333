using System;

class Program
{
    static void Main()
    {
        // Задаем фиксированные значения для M и N (четные числа)
        int M = 4, N = 4;

        // Пример матрицы M x N
        int[,] matrix = new int[M, N]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        // Меняем местами левую нижнюю и правую верхнюю четверти
        SwapQuadrants(matrix);

        Console.WriteLine("\nМатрица после замены четвертей:");
        PrintMatrix(matrix);
    }

    // Функция для вывода матрицы
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Функция для обмена местами левой нижней и правой верхней четверти
    static void SwapQuadrants(int[,] matrix)
    {
        int M = 4, N = 4;  // Установим фиксированные значения M и N
        int halfM = M / 2;
        int halfN = N / 2;

        // Временный массив для хранения правой верхней четверти
        int[,] temp = new int[halfM, halfN];

        // Скопировать правую верхнюю четверть в временный массив
        for (int i = 0; i < halfM; i++)
        {
            for (int j = halfN; j < N; j++)
            {
                temp[i, j - halfN] = matrix[i, j];
            }
        }

        // Перемещаем левую нижнюю четверть в правую верхнюю
        for (int i = halfM; i < M; i++)
        {
            for (int j = 0; j < halfN; j++)
            {
                matrix[i - halfM, j + halfN] = matrix[i, j];
            }
        }

        // Перемещаем временный массив в левую нижнюю четверть
        for (int i = 0; i < halfM; i++)
        {
            for (int j = 0; j < halfN; j++)
            {
                matrix[i + halfM, j] = temp[i, j];
            }
        }
    }
}
