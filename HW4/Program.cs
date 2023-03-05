/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


List<List<List<int>>> a = new List<List<List<int>>>();
a = FillArray(a, 2, 2, 2);

List<List<List<int>>> FillArray(List<List<List<int>>>  arr, int x = 0, int y = 0, int z = 0)
{
    for (int i = 0; i < x; i++)
    {
        arr.Add(new List<List<int>>());
        for (int j = 0; j < y; j++)
        {
            arr[i].Add(new List<int>());
            for (int k = 0; k < z; k++)
            {
                int number = new Random().Next(10, 99);
                bool isInArr = numberIsInArray(arr, number);
                while (isInArr){
                    number = new Random().Next(10, 99);
                    isInArr = numberIsInArray(arr, number);
                }
                arr[i][j].Add(number);
                Console.Write($"{a[i][j][k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
    return arr;
}

bool numberIsInArray(List<List<List<int>>> arr, int number){
    bool isInArr = false;
    int i = 0;
    int j = 0;
    while (isInArr == false && i < arr.Count)
    {
        j = 0;
        while (isInArr == false && j < arr[i].Count)
        {
            isInArr = arr[i][j].IndexOf(number) >= 0;
            j++;
        }
        i++;
    }
    return isInArr;
}