/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

double[,] array = new double[3, 4];
array = FillArray(array);
int row;
int col;
Console.Write("Введите позицию строки: ");
if (int.TryParse(Console.ReadLine()!, out row)){
    if (row <= array.GetLength(0) && row > 0){
        Console.Write("Введите позицию столбца: ");
        if (int.TryParse(Console.ReadLine()!, out col)){
            if (col <= array.GetLength(1) && col > 0){
                Console.Write($"Значение: {array[row - 1, col - 1]}");
            } else 
                Console.Write("Такой позиции не существует");
        } else 
            Console.Write("Такой позиции не существует");
    } else {
        Console.Write("Такой позиции не существует");
    }

} else 
    Console.Write("Введено не верное значение");

double[,] FillArray(double[,]  arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}