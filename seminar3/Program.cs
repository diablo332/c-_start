/* Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D плоскости.
A (3, 6); B (2, 1) -> 5, 09
A (7, -5); B (1, -1) -> 7, 21*/

double[] A = new double[2];
double[] B = new double[2];
Console.Write($"Введите координату x точки А: ");
double.TryParse(Console.ReadLine()!, out A[0]);

Console.Write($"Введите координату y точки A: ");
double.TryParse(Console.ReadLine()!, out A[1]);

Console.Write($"Введите координату x точки B: ");
double.TryParse(Console.ReadLine()!, out B[0]);

Console.Write($"Введите координату y точки B: ");
double.TryParse(Console.ReadLine()!, out B[1]);

double Xdist = Math.Pow(A[0] - B[0], 2);
double Ydist = Math.Pow(A[1] - B[1], 2);
double ans = Math.Round(Math.Sqrt(Xdist + Ydist), 2);

Console.Write($"A({A[0]};{A[1]}) B({B[0]};{B[1]}) -> {ans}");
/*
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
}*/

/* if (n == 1)
    Console.Write($"X>0 Y>0");
else if (n == 2)
    Console.Write($"X<0 Y>0");
else if (n == 3)
    Console.Write($"X<0 Y<0");    
else if (n == 4)
    Console.Write($"X>0 Y<0");    */ 