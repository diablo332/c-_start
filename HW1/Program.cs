/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Write("Введите число N: ");
int n = 0;
if (int.TryParse(Console.ReadLine(), out n)){
    Console.Write($"{NaturalNumber(n, 1)}");
}
string NaturalNumber(int n, int m)
{
  if (n == m) return n.ToString();
  else return $"{m}, {NaturalNumber(n, m + 1)}";
}