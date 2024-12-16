using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Пример входных данных
        int K = 2; // Номер серии для удвоения
        int[] array = { 1, 1, 2, 2, 2, 3, 3, 4 };

        // Обработка массива
        int[] result = TransformArray(array, K);

        // Вывод результата
        Console.WriteLine("Результат: " + string.Join(", ", result));
    }

    static int[] TransformArray(int[] array, int K)
    {
        if (K <= 0 || array.Length == 0)
            return array;

        // Разделение массива на серии
        List<List<int>> series = new List<List<int>>();
        List<int> currentSeries = new List<int> { array[0] };

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentSeries.Add(array[i]);
            }
            else
            {
                series.Add(new List<int>(currentSeries));
                currentSeries.Clear();
                currentSeries.Add(array[i]);
            }
        }
        series.Add(currentSeries); // Добавить последнюю серию

        // Если серий меньше K, вернуть массив без изменений
        if (series.Count < K)
            return array;

        // Удвоить длину K-й серии
        List<int> targetSeries = series[K - 1];
        List<int> doubledSeries = new List<int>(targetSeries);
        doubledSeries.AddRange(targetSeries);

        // Построение нового массива
        List<int> result = new List<int>();
        for (int i = 0; i < series.Count; i++)
        {
            if (i == K - 1)
                result.AddRange(doubledSeries);
            else
                result.AddRange(series[i]);
        }

        return result.ToArray();
    }
}
