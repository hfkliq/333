using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите значение M (число строк):");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N (число столбцов):");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение D (шаг прогрессии):");
        int D = int.Parse(Console.ReadLine());

        int[] numbers = new int[M];
        Console.WriteLine("Введите набор из M чисел (каждое число с новой строки):");
        for (int i = 0; i < M; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Создание и заполнение матрицы
        int[,] matrix = new int[M, N];

        // Заполнение первого столбца
        for (int i = 0; i < M; i++)
        {
            matrix[i, 0] = numbers[i];
        }

        // Заполнение остальных столбцов
        for (int j = 1; j < N; j++)
        {
            for (int i = 0; i < M; i++)
            {
                matrix[i, j] = matrix[i, j - 1] + D;
            }
        }

        // Вывод матрицы
        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
