/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = FillArray(5, 10, 99);
Console.Write($"{String.Join(", ", array)}, -> {getOddIndexesSum(array)}\n");

int getOddIndexesSum(int[] a){
    int sum = 0;
    int i = 1;
    while (i <= a.Length -1){
        sum += a[i];
        i += 2;
    }
    return sum;
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