int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}

Dictionary<int, int> dict = new Dictionary<int, int>();
foreach (var item in array)
{
    if (dict.ContainsKey(item)){
        dict[item]++;
    } else {
        dict.Add(item, 1);
    }
}

dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var item in dict)
{
    Console.Write($"Элемент {item.Key} встречается {item.Value} раз \n");
}