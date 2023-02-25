/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = FillArray(5, 100, 999);
Console.Write($"{String.Join(", ", array)}, -> {getOddNumbersCount(array)}\n");

int getOddNumbersCount(int[] a){
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr.SetValue(new Random().Next(min, max), i);
    }
    return arr;
}