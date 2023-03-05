/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int arrayLength = 4;
int[,] array = new int[arrayLength, arrayLength];

array = FillArray(array);
PrintArray(array);

void PrintArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i,j] < 10) {
            Console.Write($"0{arr[i,j]} ");
        } else {
            Console.Write($"{arr[i,j]} ");
        }
    }
    Console.WriteLine();
  }
}

int[,] FillArray(int[,] arr){
    
    int index = 1;
    int i = 0;
    int j = 0;
    while (index <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = index;
        if (j + i < arr.GetLength(1) - 1 && i <= j + 1) {
            j++;
        } else if (i < arr.GetLength(0) - 1 && j >= i + 1) {
            i++;
        } else if (i + j > arr.GetLength(1) - 1 && i >= j) {
            j--;
        } else {
            i--;
        }
        index++; 
    }
    Console.WriteLine();
    return arr;
}