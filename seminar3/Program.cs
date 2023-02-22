/* Напишите программу, которая по заданному номеру четверти показывает диапазон возможных точек в этой четверти (X и Y)*/

int n;
Console.Write($"Введите номер плоскости: ");
int.TryParse(Console.ReadLine()!, out n);

switch (n)
{
    case 1: Console.Write($"X>0 Y>0");
    break;
    case 2: Console.Write($"X<0 Y>0");
    break;
    case 6:
    case 3: 
    case 8:
    Console.Write($"X<0 Y<0");
    break;
    case 4: Console.Write($"X>0 Y<0");
    break;
    default: 
    Console.Write($"Неверно введён номер плоскости");
    break;
}

/* if (n == 1)
    Console.Write($"X>0 Y>0");
else if (n == 2)
    Console.Write($"X<0 Y>0");
else if (n == 3)
    Console.Write($"X<0 Y<0");    
else if (n == 4)
    Console.Write($"X>0 Y<0");    */ 