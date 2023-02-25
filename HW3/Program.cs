/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = FillArray(5, 10, 99);
Console.Write($"{String.Join(", ", array)}, -> {getMax(array) - getMin(array)}\n");

int getMax(int[] a){
    int max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max){
            max = a[i];
        }
    }
    return max;
}

int getMin(int[] a){
    int min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < min){
            min = a[i];
        }
    }
    return min;
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
