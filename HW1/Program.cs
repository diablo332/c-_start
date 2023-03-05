/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
List<List<int>> array = new List<List<int>>();
array = FillArray(array, 3, 4);
Console.WriteLine("--------");
for (int i = 0; i <= array.Count - 1; i++)
{
    array[i].Sort();
    array[i].Reverse();
    for (int j = 0; j <= array[i].Count - 1; j++)
    {
        Console.Write($"{array[i][j]} ");
    }
    Console.WriteLine();
}

List<List<int>> FillArray(List<List<int>>  arr, int rowCount, int colCount)
{
    for (int i = 0; i <= rowCount - 1; i++)
    {
        arr.Add(new List<int>());
        for (int j = 0; j <= colCount - 1; j++)
        {
            arr[i].Add(new Random().Next(1, 10));
            Console.Write($"{arr[i][j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

