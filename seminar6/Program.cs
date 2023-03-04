/* int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}
 */

 List<List<int>> array = new List<List<int>>();
 array.Add(new List<int>());
array[0].Add(5);
array[0].Add(1);
array[0].Add(4);
array.Add(new List<int>());
array[1].Add(5);
for (int i = 0; i <= array.Count - 1; i++)
{
    for (int j = 0; j <= array[i].Count - 1; j++)
    {
        Console.Write($"{array[i][j]} ");
    }
    Console.WriteLine();
}