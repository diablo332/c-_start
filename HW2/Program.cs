/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
double b1 = 0;
Console.WriteLine("Введите значение b1");
double.TryParse(Console.ReadLine(), out b1);

double k1 = 0;
Console.WriteLine("Введите значение k1");
double.TryParse(Console.ReadLine(), out k1);

double b2 = 0;
Console.WriteLine("Введите значение b2");
double.TryParse(Console.ReadLine(), out b2);

double k2 = 0;
Console.WriteLine("Введите значение k2");
double.TryParse(Console.ReadLine(), out k2);

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");