/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = new int[3, 4];
array = FillArray(array);
double avg = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j <= array.GetLength(1) - 1; j++)
{
    avg = 0;
    for (int i = 0; i <= array.GetLength(0) - 1; i++)
    {
        avg += array[i, j];
    }
    avg = avg / array.GetLength(0);
    Console.Write($"{Math.Round(avg, 1)}; ");
}

int[,] FillArray(int[,]  arr)
{
    for (int i = 0; i <= array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <= array.GetLength(1) - 1; j++)
        {
            array[i, j] = new Random().Next(10, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}