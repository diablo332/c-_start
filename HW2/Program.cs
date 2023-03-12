/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Write("Введите число M: ");
int m = 0;
if (int.TryParse(Console.ReadLine(), out m)){
    Console.Write("Введите число N: ");
    int n = 0;
    if (int.TryParse(Console.ReadLine(), out n)){
        int sum = getSumNaturalNumber(n, m);
        Console.Write($"Sum: {sum}");
    }
}
int getSumNaturalNumber(int n, int m)
{
  if (n == m) return n;
  else return getSumNaturalNumber(n, m + 1) + m;
}