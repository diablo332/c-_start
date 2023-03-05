/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

List<List<int>> array = new List<List<int>>();
array = FillArray(array, 4, 4);
Console.WriteLine("--------");
int rowWithMinSum = 1;
int tempSum = getSum(array[0]);
int minSum = tempSum;
for (int i = 1; i <= array.Count - 1; i++)
{
    tempSum = getSum(array[i]);
    if (tempSum < minSum){
        minSum = tempSum;
        rowWithMinSum = i + 1;
    }
}

Console.Write($"Min row number: {rowWithMinSum}");

int getSum(List<int> list){
    int sum = 0;
    for (int i = 0; i <= list.Count - 1; i++)
    {
        sum += list[i];
    }
    return sum;
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

