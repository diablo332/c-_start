/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


List<List<int>> a = new List<List<int>>();
a = FillArray(a, 2, 2);
Console.WriteLine("--------");
List<List<int>> b = new List<List<int>>();
b = FillArray(b, a.Count, a[0].Count);
Console.WriteLine("--------");
List<List<int>> c = new List<List<int>>();
for (int i = 0; i < a.Count; i++)
{
    c.Add(new List<int>());
    for (int j = 0; j < b[i].Count; j++)
    {
        c[i].Add(0);
        for (int k = 0; k < a[i].Count; k++)
        {
            c[i][j] += (a[i][k] * b[k][j]);
        }
        Console.Write($"{c[i][j]} ");
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

